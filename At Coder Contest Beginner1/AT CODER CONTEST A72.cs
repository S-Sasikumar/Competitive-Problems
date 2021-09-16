using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snuke
{
    class Program
    {
        static void Main(string[] args)
        {

            //AT CODER BEGINNER CONTEST A72//

            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int t = int.Parse(s[1]);
            if(x>t)
            {
                Console.WriteLine(x-t);
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadKey();
        }
    }
}
