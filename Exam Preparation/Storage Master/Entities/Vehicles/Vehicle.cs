using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private List<Product> trunk;

        protected Vehicle(int capacity)
        {
            Capacity = capacity;
            trunk = new List<Product>();
        }

        public IReadOnlyCollection<Product> Trunk
        {
            get { return trunk.AsReadOnly(); }
        }

        public int Capacity { get; }

        public bool IsFull
        {
            get
            {
                return (Trunk.Sum(p => p.Weight) >= Capacity);
            }
        }

        public bool IsEmpty
        {
            get
            { 
                return (Trunk.Count == 0);
            }
        }

        public void LoadProduct(Product product)
        {
            if (IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            trunk.Add(product);
        }

        public Product Unload()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            var product = trunk.LastOrDefault();
            trunk.Remove(product);

            //Product product = this.trunk[this.trunk.Count - 1];
            //this.trunk.RemoveAt(this.trunk.Count - 1);

            return product;
        }
    }
}
