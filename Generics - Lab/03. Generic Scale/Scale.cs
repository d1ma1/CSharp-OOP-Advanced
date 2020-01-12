using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class Scale<T>
        where T: IComparable<T>
    {
        public T Left { get; set; }
        public T Right { get; set; }

        public Scale(T left, T right)
        {
            Left = left;
            Right = right;
        }

        public T GetHeavier()
        {
            if (Left.CompareTo(Right)>0)
            {
                return Left;
            }
            if (Left.CompareTo(Right) < 0)
            {
                return Right;
            }

            return default(T);
        }
    }
}
