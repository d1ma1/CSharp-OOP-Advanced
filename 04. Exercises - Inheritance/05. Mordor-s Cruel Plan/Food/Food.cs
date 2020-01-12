using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Food
{
    public abstract class Food
    {
        public int Point { get; set; }

        public Food(int point)
        {
            Point = point;
        }
    }
}
