using System;

namespace GenericsApplicationDemo
{
    class MaximumNumberMain
    {
        static void Main(string[] args)
        {
            int intResult = MaximumNumberDemo.MaximumNumber(40, 50, 100);
            Console.WriteLine("Maximum Integer : " + intResult);
        }
    }
}
