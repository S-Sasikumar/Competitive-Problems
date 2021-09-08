using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderBeginnerContest_A063
{
    class Program
    {
        static void Main(string[] args)
        {
            restricted();
        }

        public static void restricted()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            if (a + b < 10)
            {

                Console.WriteLine(a + b);

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}