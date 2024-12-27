using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, r, s;
            Console.Write("please enter a number");
            x = Convert.ToInt32(Console.ReadLine());
            s = 0;
            do
            {
                r = x % 10;
                s = s * 10 + r;
                x = x / 10;
            } while (x > 0);
            Console.Write("reverse number is" + s);
            Console.ReadKey();
            
            

        }
    }
}
