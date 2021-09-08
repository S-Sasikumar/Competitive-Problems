using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atcoderbeginnercontest051
{
    class Program
    {
        static void Main(string[] args)
        {
            haiku();
        }

        public static void haiku()
        {
            string a = Console.ReadLine();
            char b = ' ';
            int i;
            string s = " ";

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == ',')
                {
                    s = a.Replace(',', b);

                }

            }
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
