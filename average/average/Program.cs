using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, avg;
            Console.WriteLine("please enter 2 numbers");
            a = Convert.ToInt32(System.Console.ReadLine());
            b = Convert.ToInt32(System.Console.ReadLine());
            sum = a + b;
            avg = sum / 2;
            System.Console.Write(avg);
            System.Console.ReadKey();

        }
    }
}
