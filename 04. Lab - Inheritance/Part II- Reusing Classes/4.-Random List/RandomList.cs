using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList: List<string>
    {
        private Random rnd;

        //public Random rnd { get; set; }

        public RandomList()
        {
            rnd = new Random();
        }
        public string RandomString()
        {
            int index = rnd.Next(0, Count - 1);
            string str = this[index];
            RemoveAt(index);
            return str;
        }
    }
}
