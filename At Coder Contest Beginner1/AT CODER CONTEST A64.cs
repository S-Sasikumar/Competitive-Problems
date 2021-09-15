using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgbcard
{
    class Program
    {
        static void Main(string[] args)
        {
            rgbcard();
            
        }
        #region At Coder Contest Beginner 64

        public static void rgbcard()
        {
            string[] n = Console.ReadLine().Split(' ');
            int r = int.Parse(n[0]);
            int g=int.Parse(n[1]);
            int b=int.Parse(n[2]);
            int sum=100*r+10*g+b;

            if(sum%4==0)
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
    }
}
