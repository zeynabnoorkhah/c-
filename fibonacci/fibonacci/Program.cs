using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f1 = 1; int f2 = 1; int temp;
            Console.WriteLine(f1 + "");
            Console.WriteLine(f2 + "");
            for (int i = 1; i <= 10; i++);
            {
                temp = f2;
                f2 = f1 + f2;
                f1 = temp;
                Console.WriteLine(f2 + "");
            }
            Console.ReadKey();
        }
    }
}
