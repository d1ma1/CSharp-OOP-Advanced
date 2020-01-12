using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public abstract class Storage
    {
        public string Name { get; }
        public int Capacity { get; }
        public int GarageSlots { get; }

        private List<Product> products;

        public IReadOnlyCollection<Product> Products
        {
            get { return products.AsReadOnly(); }
        }

        public bool IsFull
        {
            get
            {
                return (Products.Sum(p => p.Weight) >= Capacity);
            }
        }

        private Vehicle[] garage;

        public IReadOnlyCollection<Vehicle> Garage
        {
            get { return Array.AsReadOnly(garage); }
        }

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = garageSlots;
            products = new List<Product>();
            garage = new Vehicle[GarageSlots];

            var index = 0;
            foreach (var vehicle in vehicles)
            {
                garage[index] = vehicle;
                index++;
            }
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot>=GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            var vehicle = garage[garageSlot];

            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            var vehicle = GetVehicle(garageSlot);

            int index = deliveryLocation.AddVehicleToGarage(vehicle);
            this.garage[garageSlot] = null;

            return index;


            //var count = 0;
            // var index = 0;
            // for (int i = 0; i < deliveryLocation.GarageSlots; i++)
            // {
            //     if (deliveryLocation.garage[GarageSlots]==null)
            //     {
            //         deliveryLocation.garage[GarageSlots] = vehicle;
            //         this.garage[garageSlot] = null;
            //         count++;
            //         index = i;
            //         break;
            //     }
            // }
            // if (count == 0)
            // {
            //     throw new InvalidOperationException("No room in garage!");
            // }

            // return index;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);

            int unloadedProductsCounter = 0;
            while (!this.IsFull && !vehicle.IsEmpty)
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                unloadedProductsCounter++;
            }

            return unloadedProductsCounter;
        }

        private int AddVehicleToGarage(Vehicle vehicle)
        {
            int freeGarageSlotIndex = Array.IndexOf(this.garage, null);

            if (freeGarageSlotIndex == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            this.garage[freeGarageSlotIndex] = vehicle;

            return freeGarageSlotIndex;
        }
    }
}
