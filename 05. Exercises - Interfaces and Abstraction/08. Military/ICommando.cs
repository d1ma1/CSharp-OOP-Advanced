using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ICommando: ISpecialisedSoldier, IMission
    {
       List<IMission> Mission { get; set; }
    }
}
