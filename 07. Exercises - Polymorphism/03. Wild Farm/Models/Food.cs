using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        public Food(int quantity)
        {
            Quantity = quantity;
        }
    }
}
