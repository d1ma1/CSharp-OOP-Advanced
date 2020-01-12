using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> list;

        public Lake(int[] args)
        {
            list = new List<int>(args);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i=i+2)
            {
                yield return list[i];
            }
            var j = list.Count - 1;
            if (list.Count%2==1)
            {
                j=list.Count - 2;
            }
            for (int i =j; i >= 1; i = i - 2)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


    }
}
