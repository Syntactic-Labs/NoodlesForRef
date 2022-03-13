using System;

namespace NoodlesForRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "PHP";
            if (str.Substring(0,2)== "PH")
            {
                for (int i = 0; i < 10; i++)
                {

                Console.WriteLine(str.Substring(0,2));
                }
            }
            
        }
    }
}
