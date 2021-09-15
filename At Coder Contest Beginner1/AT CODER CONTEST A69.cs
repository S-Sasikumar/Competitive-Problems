using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcity
{
    class Program
    {
        static void Main(string[] args)
        {
            //AT CODER CONTEST BEGINNER A 69//

            string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);

            Console.WriteLine((n-1)*(m-1));
            Console.ReadKey();

        }

        
    }
}
