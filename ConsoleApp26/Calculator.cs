using System;


namespace ConsoleApp26
{
    class Calculator<T>
    {
        public Calculator(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; set; }
        public T Y { get; set; }

        public T Calculate(Func<T,T,T> mathOperation)
        {

            return mathOperation(X, Y);
        }

    }
}
