using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderBeginnerContest164
{
    class Program
    {
        static void Main(string[] args)
        {
            sheep164();
        }
        public static void sheep164()
        {
            string[] a = Console.ReadLine().Split(' ');
            int s = int.Parse(a[0]);
            int w = int.Parse(a[1]);

            if (s <= w)
            {
                Console.WriteLine("unsafe");
            }
            else
            {
                Console.WriteLine("safe");
            }
            Console.ReadKey();
        }
    }
}
