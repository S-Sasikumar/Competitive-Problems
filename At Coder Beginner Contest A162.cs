using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderBeginnerContest_A162
{
    class Program
    {
        static void Main(string[] args)
        {
            Alucky162();
        }
        public static void Alucky162()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int n1, n2, n3, n4;
            n1 = n % 10;
            n2 = n / 10;
            n4 = n2 % 10;
            n3 = n / 100;

            if (n1 == 7 || n4 == 7 || n3 == 7)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
