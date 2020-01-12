using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class DistributionCenter : Storage
    {
        private static Vehicle[] DefaultVehicles =
{
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter(string name) : 
            base(name, 2, 5, DefaultVehicles)
        {
        }
    }
}
