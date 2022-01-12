using System;
using System.Collections.Generic;
//Func<string,decimal,string> PaymentService
namespace ConsoleApp26
{
    class Program
    {
        static int GetIndex<T>(List<T> list, T value) where T: IComparable<T>
        {
            for (int i=0; i<list.Count; i++)
            {
                if (value.CompareTo(list[i])>0) return i;
            }
            return -1;
        }
       
        static void Main(string[] args)
        {

        }
    }
}
