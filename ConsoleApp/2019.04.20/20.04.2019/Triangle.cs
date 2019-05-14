using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Apr20
{
    class Triangle
    {

        public static void TriangleOfConsecutiveOddNumbers()
        {
            int rowSum=0;
            int numbersInRow=1;
            int numbersInNextRow=2;
            for (int i = 1; i < 30; i+=2)
            {
                rowSum += i;
                Console.Write(i + "\t");
                numbersInRow++;
                if (numbersInRow==numbersInNextRow)
                {
                    Console.WriteLine($"RowSum: {rowSum}");
                    rowSum = 0;
                    numbersInNextRow = numbersInRow+1;
                    numbersInRow = 1;
                }
            }
        }
    }
}
