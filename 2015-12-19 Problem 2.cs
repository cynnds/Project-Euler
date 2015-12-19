using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int total = 0, x=0, y=1, z=0;

                while (y <= 4000000)
                {
                    z = x + y;
                    x = y ;
                    y = z;

                    if (y%2 == 0)
                        total += y;
                }

                Console.WriteLine(total);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
