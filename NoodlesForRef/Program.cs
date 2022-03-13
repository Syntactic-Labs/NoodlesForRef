using System;
using System.Collections.Generic;
using System.Linq;

namespace NoodlesForRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxNum=0;
            var minNum=99;
            int[] num = new int[] { 15, 20, 25 };
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > maxNum)
                {
                    maxNum = num[i];
                }
                if (num[i] < minNum)
                {
                    minNum = num[i];
                }
            }
                Console.WriteLine($"min number is: {minNum}");
                Console.WriteLine($"max number is: {maxNum}");
                Console.WriteLine("The min number is " + num.Min());

        }
    }
}
