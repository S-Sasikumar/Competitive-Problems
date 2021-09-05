using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            //random();
            //swap();
            //factor();
            //prime();

            int i = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            string s = Convert.ToString(Console.ReadLine());

            string q = "HackerRank is the best place to learn and practice coding!";
           sum(i, d, s, q);

        }
       
        #region
        public static void random()
        {
            string[] a = new string[] {"sasi","bala","abu","hari","davu"};
            Random ron = new Random();
            int s=ron.Next(a.Length);
            Console.WriteLine(a[s]);
            Console.ReadKey();

        }
        #endregion

        #region
        public static void swap()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp
                ;

            Console.WriteLine("a="+a+"b="+b+"c="+c);
            Console.ReadKey();

        }
        #endregion

        #region
        public static void factor()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=a;i++ )
            {
                if(a%i==0)
                {
                    Console.WriteLine(i);
                   
                }

            }
            Console.ReadKey();
            
        }

        #endregion
        public static void sum(int i,double d,string s,string q)
        {
            i = ++i;
            d = ++d;
            Console.WriteLine("", i, "", d, "", s = q);
            Console.ReadKey();
        }

      

      
    }
}