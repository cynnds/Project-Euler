using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        Find the sum of all the multiples of 3 or 5 below 1000. */

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number, total = 0;
                bool isInt = Int32.TryParse(args[0], out number);

                if (args.Length != 1 || !isInt)
                {
                    throw new ArgumentException("Only 1 argument can be passed.");
                }

                for (int i = 1; i < number; i++)
                {
                    if (i%3 == 0 || i%5 == 0)
                    {
                        total += i;
                    }
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
