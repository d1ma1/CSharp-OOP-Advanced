using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public  List<T> Boxes { get; }
        public int Count => this.Boxes.Count;

        public Box()
        {
            Boxes = new List<T>();
        }

        public void Add(T element)
        {
            Boxes.Add(element);
        }

        public T Remove()
        {
            T element = this.Boxes[Count - 1];
            this.Boxes.RemoveAt(this.Boxes.Count - 1);

            return element;
        }
    }
}
