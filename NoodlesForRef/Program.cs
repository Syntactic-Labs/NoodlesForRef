using System;

namespace NoodlesForRef
{
    class Program
    {
        static void Main(string[] args)
        {
            var samp = "PHP Tutorial";
            if (samp.Contains("HP"))
            {
                var newSamp = samp.Replace("HP", "");
                Console.WriteLine(newSamp);
            }
            
        }
    }
}
