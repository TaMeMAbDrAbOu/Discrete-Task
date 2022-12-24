using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("the first No : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("the seconde No : ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("the prime numbers here is : ");

            for (int m = x; m <= y; m++)
            {
                int c = 0;

                for (int n = 2; n < m; n++)
                {
                    if (m % n == 0)
                    {
                        c++;
                        break;
                    }
                }

                if (c == 0 && m != 1)
                    Console.WriteLine(m);




            }

           }
        }
    }

