using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    public class Box<T>
    {
        private List<T> list;
        public T Element { get; set; }
        public IReadOnlyList<T> List => list.AsReadOnly();

        public Box(T element)
        {
            Element = element;
            list = new List<T>();
        }

        public override string ToString()
        {
            return Element.GetType().FullName + ": " + Element;
        }
    }
}
