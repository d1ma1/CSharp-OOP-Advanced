using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class Listche<T> : IComparable<T>, IEnumerable<T> where T : IComparable
    {
        private List<T> list;

        public T Element { get; }
        public IReadOnlyCollection<T> List => list.AsReadOnly();

        public Listche()
        {
            list = new List<T>();
        }

        public Listche(T element)
        {
            Element = element;
            list = new List<T>();
        }
        public void Add(T element)
        {
            list.Add(element);
        }

       public T Remove(int index)
        {
            var removed = list[index];
            list.Remove(removed);
            return removed;
        }
       public bool Contains(T element)
        {
            if (list.Contains(element))
            {
                return true;
            }
            return false;
        }
       public void Swap(int ind1, int ind2)
        {
            var temp = list[ind1];
            list[ind1] = list[ind2];
            list[ind2] = temp;
        }
       public int CountGreaterThan(T element)
        {
            var count = 0;
            foreach (var item in list)
            {
                if (element.CompareTo(item)<0)
                {
                    count++;
                }
            }
            return count;
        }
        public T Max()
        {
            T max = list[0];

            foreach (var item in list)
            {
                if (max.CompareTo(item)<0)
                {
                    max = item;
                }
            }

            return max;
        }
        public T Min()
        {
            T min = list[0];

            foreach (var item in list)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }
        public int CompareTo(T other)
        {
            return other.CompareTo(Element);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in List)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in List)
            {
                yield return item;
            }
        }
    }
}
