using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromic_Number
{
    class Program
    {
        static void Main(string[] args)
        {

           //AT CODER BEGINNER CONTEST A 70//

            string n = Console.ReadLine();
            
            if (n[0] == n[2])
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
