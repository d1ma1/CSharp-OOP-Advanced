using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class ListyIterator<T>: IEnumerable<T>
    {
        private List<T> listy;
        public List<T> Listy { get; set; }
        private int currentIndex = 0;

        public ListyIterator()
        {
            Listy = new List<T>();
        }

        public bool Move()
        {
            if (currentIndex < Listy.Count-1)
            {
                currentIndex++;
                return true;
            }
            return false;
        }

        public string Print()
        {
            if (this.currentIndex > this.Listy.Count - 1)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
           return Listy[currentIndex].ToString();
        }

        public bool HasNext()
        {
            if (currentIndex + 1 < Listy.Count)
            {
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Listy)
            {
                yield return item;
            }  
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();       
    }
}
