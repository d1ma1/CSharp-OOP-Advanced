using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari_
{
    public interface IFerarri
    {
        string Model { get; set; }
        string Driver { get; set; }

        string Braking();
        string Gasing();
    }
}
