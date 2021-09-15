using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i18n
{
    class Program
    {
        static void Main(string[] args)
        {
            //AT CODER CONTEST BEGINNER B 69//

            string s = Console.ReadLine();

            int count = 0;
            for (int i = 1; i < s.Length - 1; i++)
            {
                count++;
            }
            Console.WriteLine(s[0] + "" + count + "" + s[s.Length - 1]);

            Console.ReadKey();

        }
    }
}
