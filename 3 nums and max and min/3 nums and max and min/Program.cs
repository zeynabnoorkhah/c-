using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_nums_and_max_and_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, k = 3, b = 4, c = 5;
            if (b > a)
            {
                k = a; a = b; b = k;
            }
            else if (c > a)
            {
                k = a; a = c; c = k;
            }
            else if (c > b) ;
            {
                k = b;b = c;c = k;
            }
            Console.WriteLine("max num is" + a);
            Console.WriteLine("min num is" + c);
            Console.ReadKey();
       
        }
    }
}
