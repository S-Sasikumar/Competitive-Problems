using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderBeginnerContest_A059
{
    class Program
    {
        static void Main(string[] args)
        {
            //acronym59();
            //comparsion();
            //shiritori60();
            //betweentwointeger61();
            //ringring66();
            //sharingcookies();

        }
        #region At Coder Contest Beginner A 059

        public static void acronym59()
        {
            string[] s = Console.ReadLine().Split(' ');
            string s1 = s[0];
            string s2 = s[1];
            string s3 = s[2];
            char.ToUpper(s1[0]);
            char.ToUpper(s2[0]);
            char.ToUpper(s3[0]);
            Console.Write(char.ToUpper(s1[0]) + "" + char.ToUpper(s2[0]) + "" + char.ToUpper(s3[0]));
            Console.ReadKey();

        }
        #endregion

        #region At Coder Beginner Contest B 059

        public static void comparsion()
        {
            double A= Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
             
            if(A>B)
            {
                Console.WriteLine("GREATER");
            }
             else if (A<B)
            {
                Console.WriteLine("LESS");
            }
            else if (A == B)
            {
                Console.WriteLine("EQUAL");
            }
           
           
            Console.ReadKey();
        }
        #endregion

        #region At Coder Beginner Contest A 60

        public static void shiritori60()
        {
            string[] s = Console.ReadLine().ToLower().Split(' ');
            string a = s[0];
            string b = s[1];
            string c = s[2];

            
            
                if (a[a.Length - 1] == b[0] && b[b.Length - 1] == c[0])
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

        #region At Coder Beginner Contest A 061

        public static void betweentwointeger61()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a =int.Parse(s[0]);
            int b =int.Parse(s[1]);
            int c =int.Parse(s[2]);

            if (c>=a && c<=b)
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

        #region At Coder Beginner Contest A 66

        public static void ringring66()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);

            int max = a;
            if(b>max)
            {
                max = b;
            }
            if(c>max)
            {
                max = c;
            }
            Console.WriteLine(a+b+c-max);
            Console.ReadKey();
        }
        #endregion

        #region At Coder Beginner Contest A 67

        public static void sharingcookies()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            if(a % 3 == 0 || b % 3 == 0 || (a + b) % 3 == 0)
            {
                Console.WriteLine("Possible");
            }
            else
            {
                Console.WriteLine("Impossible");
            }
            Console.ReadKey();
        }
        #endregion
    }
}
