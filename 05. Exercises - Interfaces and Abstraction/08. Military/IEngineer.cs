using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IEngineer: ISpecialisedSoldier, IRepair
    {
        List<IRepair> Repairs { get; set; }
    }
}
