using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theater
{
    class Program
    {
        static void Main(string[] args)
        {

            //AT CODER CONTEST BEGINNER B73//

            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                sum += b - a + 1;
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
