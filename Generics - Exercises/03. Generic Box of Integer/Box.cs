using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    public class Box<T>
    {
        public T Element { get; set; }

        public Box(T element)
        {
            Element = element;
        }

        public override string ToString()
        {
            return Element.GetType().FullName + ": " + Element;
        }
    }
}
