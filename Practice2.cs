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
            //strings();
            //CodeFestival();



        }
       
        #region RANDOM

        public static void random()
        {
            string[] a = new string[] {"sasi","bala","abu","hari","davu"};
            Random ron = new Random();
            int s=ron.Next(a.Length);
            Console.WriteLine(a[s]);
            Console.ReadKey();

        }
        #endregion

        #region SWAP

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

        #region FACTOR

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

        #region CODE FESTIVAL

        public static void CodeFestival()
        {


            string s = Console.ReadLine();
           
            
            for (int i =0; i < 12; i++)
            {
                
                    if (i== 4)
                    {

                        Console.Write(" ");
                    }
                  
                    Console.Write((s[i]));
            }

            Console.WriteLine();
        }
    
        #endregion

    }
}