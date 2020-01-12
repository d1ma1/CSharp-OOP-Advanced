using StorageMaster.Entities.Factories;
using StorageMaster.Entities.Products;
using StorageMaster.Entities.Storages;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster
{
    public class StorageMaster
    {
        private Dictionary<string, Stack<Product>> products;
        private Dictionary<string, Storage> storages;

        private ProductFactory productFactory;
        private StorageFactory storageFactory;

        private Vehicle currentVehicle;

        public StorageMaster()
        {
            products = new Dictionary<string, Stack<Product>>();
            storages = new Dictionary<string, Storage>();

            productFactory = new ProductFactory();
            storageFactory = new StorageFactory();
        }

        public string AddProduct(string type, double price)
        {
            var product = productFactory.CreateProduct(type, price);

            if (!this.products.ContainsKey(type))
            {
                this.products.Add(type, new Stack<Product>());
            }

            products[type].Push(product);

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            var storage = storageFactory.CreateStorage(type, name);

            storages[name] = storage;

            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = storages[storageName];

            currentVehicle = storage.GetVehicle(garageSlot);

            return $"Selected {currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            // TO RE-DO
            var cc = 0;
            int loadedProductsCount = 0;
            foreach (string productName in productNames)
            {
                cc++;
                if (this.currentVehicle.IsFull)
                {
                    break;
                }

                if (!this.products.ContainsKey(productName) ||
                    this.products[productName].Count == 0)
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
                }

                Product product = this.products[productName].Pop();

                this.currentVehicle.LoadProduct(product);
                loadedProductsCount++;
            }

            string result = $"Loaded {loadedProductsCount}/{cc} products into {this.currentVehicle.GetType().Name}";
            return result;
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (!this.storages.ContainsKey(sourceName))
            {
                throw new InvalidOperationException("Invalid source storage!");
            }

            if (!this.storages.ContainsKey(destinationName))
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Storage sourceStorage = this.storages[sourceName];
            Storage destinationStorage = this.storages[destinationName];
            Vehicle vehicle = sourceStorage.GetVehicle(sourceGarageSlot);

            int destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            string result = $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
            return result;
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            var storage = storages[storageName];
            int countProductsInVehicle = storage.GetVehicle(garageSlot).Trunk.Count;
            int unloadedProductsCounter = storage.UnloadVehicle(garageSlot);

            string result = $"Unloaded {unloadedProductsCounter}/{countProductsInVehicle} products at {storageName}";
            return result;
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storages[storageName];

            Dictionary<string, int> productsAndCount = new Dictionary<string, int>();
            foreach (Product product in storage.Products)
            {
                string productTypeName = product.GetType().Name;

                if (!productsAndCount.ContainsKey(productTypeName))
                {
                    productsAndCount.Add(productTypeName, 1);
                }
                else
                {
                    productsAndCount[productTypeName]++;
                }
            }

            double productsSum = storage.Products.Sum(p => p.Weight);
            int storageCapacity = storage.Capacity;

            //Dictionary<string, int> sortedProducts = productsAndCount
            //      .OrderByDescending(p => p.Value)
            //      .ThenBy(p => p.Key)
            //      .ToDictionary(x => x.Key, x => x.Value);

            //string[] productsAsStrings = new string[sortedProducts.Count];

            //int index = 0;
            //foreach (var product in sortedProducts)
            //{
            //    string currentResult = $"{product.Key} ({product.Value})";
            //    productsAsStrings[index++] = currentResult;
            //}

            string[] productsAsStrings = productsAndCount
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key)
                .Select(kvp => $"{kvp.Key} ({kvp.Value})")
                .ToArray();

            string stockLine = $"Stock ({productsSum}/{storageCapacity}): [{string.Join(", ", productsAsStrings)}]";

            //string[] storageStringRepresentation = new string[storage.GarageSlots];
            //int index = 0;
            //foreach (Vehicle vehicle in storage.Garage)
            //{
            //    if (vehicle == null)
            //    {
            //        storageStringRepresentation[index++] = "empty";
            //    }
            //    else
            //    {
            //        storageStringRepresentation[index++] = vehicle.GetType().Name;
            //    }
            //}

            string[] storageStringRepresentation = storage
                .Garage
                .Select(g => g == null ? "empty" : g.GetType().Name)
                .ToArray();

            string garageLine = $"Garage: [{string.Join("|", storageStringRepresentation)}]";

            string result = stockLine +
                            Environment.NewLine +
                            garageLine;

            return result;
        }

        public string GetSummary()
        {
            Storage[] sortedStorages = this.storages
                      .Select(s => s.Value)
                      .OrderByDescending(s => s.Products.Sum(p => p.Price))
                     .ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (Storage storage in sortedStorages)
            {
                double totalMoney = storage.Products.Sum(p => p.Price);

                sb.AppendLine($"{storage.Name}:");
                sb.AppendLine($"Storage worth: ${totalMoney:F2}");
            }

            string result = sb.ToString().TrimEnd();
            return result;
        }

    }
}
