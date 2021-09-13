using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_Coder_contest_Beginners
{
    class Program
    {
        static void Main(string[] args)
        {
            ABCXXX68();
            breaknumber68();
            kcity69();
        }


        #region At Coder Contest Beginner A68

        public static void ABCXXX68()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ABC" + n);

            Console.ReadKey();
        }
        #endregion

        #region At Coder Beginner Contest A68

        public static void breaknumber68()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }

            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
        #endregion

        #region At Coder Beginner Contest kcity A69

        public static void kcity69()
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            n = n - 1;
            m = m - 1;
            int a = n * m;
            Console.WriteLine(a);
            Console.ReadKey();
        }
        #endregion
    }
}
