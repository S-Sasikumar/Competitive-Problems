using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practices1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort();
           // Sort();
            //sum();
            strings();
            
        }

        #region
        public static void sort()
        {

            int[] s = new int[] { 4, 5, 2, 2, 4, 5, 10, 20 };
            Array.Sort(s);
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.ReadKey();
        }
        #endregion
        #region
        public static void Sort()
        {
            int[] a = new int[] { 2, 4, 3, 5, 6, 4, 6, 1, 2, 10 };
            int temp = 0;
            for (int i = 0; i < a.Length;i++ )
            {
                for (int j = i; j < a.Length;j++ )
                {
                    if(a[j]<a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                       
                    }
                }
                Console.WriteLine(a[i]);  
            }
            Console.ReadKey();
        }
        #endregion
        #region
        public static void sum()
        {
            int a =int.Parse(Console.ReadLine());
            string[] st=Console.ReadLine().Split(' ');
            int b = int.Parse(st[0]);
            int c = int.Parse(st[1]);
            string s = Console.ReadLine();
            Console.WriteLine((a+b+c)+" "+s);
            
        }
        #endregion
        #region
        public static void strings()
    {
        int[] s = new int[5] { };
        int count = 0;
        for (int i = 0; i < s.Length;i++ )
        {
            count = count + 1;
            Console.WriteLine(count);
        }
        Console.ReadKey();

    }
        #endregion
    }
}
