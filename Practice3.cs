using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //irohaandhaiku();
            //roundupthemean();
            //addandsub();
            //vowels();

        }


        #region IROHA AND HAIKU 42

        public static void irohaandhaiku()
        {
            string[] st = Console.ReadLine().Split(' ');
            int a = int.Parse(st[0]);
            int b = int.Parse(st[1]);
            int c = int.Parse(st[2]);
            if((a==5||b==5||c==7)&&(a==7||b==5||c==5))
            {
                
                    Console.WriteLine("YES");
                
                
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
        #endregion


        #region ROUND THE MEAN 82

        public static void roundupthemean()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            
            int c = (a + b+1) / 2;
          
            Console.WriteLine(c);
           
        }
        #endregion

        #region ADDITION AND SUBTRACTION 50

        public static void addandsub()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            char op = char.Parse(s[1]);
            int b = int.Parse(s[2]);

            if(op=='+')
            {
                Console.WriteLine(a+b);
            }
            if(op=='-')
            {
                Console.WriteLine(a - b);
            }
          
        }
        #endregion

        #region VOWELS 49

        public static void vowels()
        {
            char c =Convert.ToChar (Console.ReadLine());
           
            if(c=='a'||c=='e'||c=='i'||c=='o'||c=='u')
            {

                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
            Console.ReadKey();
            
        }
        #endregion

        #region HAIKU 51

        public static void haiku()
        {
            string[] s=conso
        }
        #endregion


    }
}