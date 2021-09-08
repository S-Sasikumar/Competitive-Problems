using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atcoderbeginner53
{
    class Program
    {
        static void Main(string[] args)
        {
            abcorarc();
        }
        public static void abcorarc()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 1200)
            {
                Console.WriteLine("ABC");
            }
            else
            {
                Console.WriteLine("ARC");
            }
            Console.ReadKey();
        }
    }
}
