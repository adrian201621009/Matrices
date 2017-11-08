using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = { { 5, 7, 8 }, { 5, 8, 1 }, { 7, 8, 0 } };
            int Sumadia = 0;
            for (int x = 0; x < 3; x++)
            {
                Sumadia = Sumadia + m[x, x];

            }
                Console.WriteLine(" la suma de la diagonal es:"+ Sumadia );
                Console.ReadKey();
            }
        }
    }

