using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addandsub
{
    class Program
    {
        static void Main(string[] args)
        {

            //AT CODER BEGINNER CONTEST B 76//

            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int i=0;
            int sum = 1;
            while(i<n)
            {

                if (sum * 2 <= sum + k)
                {

                    sum += sum;
                }
                else
                {
                    sum += k;
                }
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
