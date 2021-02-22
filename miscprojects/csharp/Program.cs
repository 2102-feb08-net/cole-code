using System;
using System.Collections.Generic;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(FiboSolver(20));

        }

        static int FiboSolver(int index)
        {
            if (index == 1 | index == 2)
            {
                return 1;
            }

            else
            {

                return FiboSolver(index - 2) + FiboSolver(index - 1);
            }
        }

    }
}
