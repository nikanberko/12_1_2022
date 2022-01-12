using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class Comparer<T> where T : IComparable<T>
    {
        public Comparer(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; }
        public T Y { get; set; }
        


        public bool Compare(Func<T, T, bool> compareOperation)
        {

            return compareOperation(X, Y);
        }

    }
}
