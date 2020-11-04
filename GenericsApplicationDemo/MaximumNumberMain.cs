using System;
using GenericsApplicationDemo;

namespace GenericsApplicationDemo
{
    class MaximumNumberMain
    {
        static void Main(string[] args)
        {
            int maxNumber = new MaximumNumberDemo<int>(10, 20, 30).MaxMethod();
            Console.WriteLine("Maximum of Three integers : " + maxNumber);

            float floatNumber = new MaximumNumberDemo<float>(125.20f, 58.75f, 684.12f).MaxMethod();
            Console.WriteLine("Maximum of Three Float NUmbers : " + floatNumber);

            string stringResult = new MaximumNumberDemo<string>("Strawberry", "Orange", "Grapes").MaxMethod();
            Console.WriteLine("Maximum of three strings : " + stringResult);
        }
    }
}
