using System;
using GenericsApplicationDemo;

namespace GenericsApplicationDemo
{
    class MaximumNumberMain
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 4, 8, 10 };
            float[] floatArray = { 5.6f, 10.5f, 8.9f, 59.65f };
            string[] strArray = {"Chetan","Shah","Akshay"};

            MaximumNumberDemo<int> maximumNumberDemo = new MaximumNumberDemo<int>(intArray);
            maximumNumberDemo.ToPrint();

            MaximumNumberDemo<float> maximumNumberDemo1 = new MaximumNumberDemo<float>(floatArray);
            maximumNumberDemo1.ToPrint();

            MaximumNumberDemo<string> maximumNumberDemo2 = new MaximumNumberDemo<string>(strArray);
            maximumNumberDemo2.ToPrint();
        }
    }
}
