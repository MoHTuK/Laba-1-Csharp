using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, result;
            Console.WriteLine("Enter your 1 number\n");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your 2 number \n");
            y = double.Parse(Console.ReadLine());
            result = x + y;
            Console.WriteLine("Your result =  " + result);
            Console.ReadKey();
        }
    }
}
