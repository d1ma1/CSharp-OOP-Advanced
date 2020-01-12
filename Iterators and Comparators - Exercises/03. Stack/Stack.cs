using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> customStack;

        public Stack()
        {
            customStack = new List<T>();
        }

        public void Push(T item)
        {
            customStack.Add(item);
        }
        public void Pop()
        {
            if (customStack.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            var result = customStack[customStack.Count - 1];
            customStack.Remove(result);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = customStack.Count-1; i >= 0; i--)
            {
                yield return customStack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
