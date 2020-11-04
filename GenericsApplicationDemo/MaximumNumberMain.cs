using System;

namespace GenericsApplicationDemo
{
    class MaximumNumberMain
    {
        static void Main(string[] args)
        {
            int intResult = MaximumNumberDemo.MaximumNumber(40, 50, 100);
            Console.WriteLine("Maximum Integer : " + intResult);

            float floatResult = MaximumNumberDemo.MaximumFloatNumber(50.25f, 56.24f, 100.5f);
            Console.WriteLine("Maximum Integer : " + floatResult);
        }
    }
}
