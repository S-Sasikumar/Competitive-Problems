using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_out_of_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //AT CODER BEGINNER CONTEST A75//

            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);

            if(a==c)
            {
                Console.WriteLine(b);
            }
            if(a==b)
            {
                Console.WriteLine(c);
            }
            if(b==c)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
