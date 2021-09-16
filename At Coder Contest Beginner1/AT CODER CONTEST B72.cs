using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddstring
{
    class Program
    {
        static void Main(string[] args)
        {

            //AT CODER BEGINNER CONTEST B72//

            string s = Console.ReadLine();
            for (int i = 0; i < s.Length;i++ )
            {
                if(i%2==0)
                {
                    Console.Write(s[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
