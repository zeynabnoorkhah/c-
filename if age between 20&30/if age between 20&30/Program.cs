using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_age_between_20_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userAge;
            Console.WriteLine("please enter your age");
            string Age;
            Age = Console.ReadLine();
            userAge = int.Parse(Age);
            string res;
            if (userAge < 30 & userAge > 20)
            {
                res = "hello";
            }
            else
            {
                res = "bye";
            }
            Console.WriteLine(res);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
