using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class AutomatedWarehouse : Storage
    {
        public AutomatedWarehouse(string name) :
            base(name, 1, 2, new Vehicle[1] { new Truck() })
        {
        }
    }
}
