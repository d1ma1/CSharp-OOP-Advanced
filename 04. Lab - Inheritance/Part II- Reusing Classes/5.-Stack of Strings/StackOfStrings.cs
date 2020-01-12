using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings
    {
        private List<string> data;
        public StackOfStrings()
        {

        }

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty");
            }

            var element = data.Last();
            data.RemoveAt(data.Count-1);
            return element;
        }
        public string Peek()
        {
            return data.Last();
        }
        public bool IsEmpty()
        {
            if (data.Count>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
