using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotation
{
    class Program
    {
        static void Main(string[] args)
        {

            //AT CODER BEGINNER CONTEST C76//

            string s = Console.ReadLine();
            string s1=Console.ReadLine();
            string v = "";
            for (int i =s.Length-1;i>=0;i-- )
            {

                v+=s[i];

            }
            if (v == s1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
          
            Console.ReadKey();
        }
    }
}
