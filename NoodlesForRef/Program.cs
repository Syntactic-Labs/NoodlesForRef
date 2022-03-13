using System;

namespace NoodlesForRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number between -10 and 10...:");
            var i = Convert.ToInt32(Console.ReadLine());
            if (i > -10 && i < 10)
            {
                Console.WriteLine("i IS within the permited range.");
            }else
            {
                Console.WriteLine("i NOT within the permited range.");
            }
        }
    }
}
