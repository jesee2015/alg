using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSanjiao(10);
            Console.Read();
        }



        //# [1]
        //# [1, 1]
        //# [1, 2, 1]
        //# [1, 3, 3, 1]
        //# [1, 4, 6, 4, 1]
        //# [1, 5, 10, 10, 5, 1]
        //# [1, 6, 15, 20, 15, 6, 1]
        //# [1, 7, 21, 35, 35, 21, 7, 1]
        //# [1, 8, 28, 56, 70, 56, 28, 8, 1]
        //# [1, 9, 36, 84, 126, 126, 84, 36, 9, 1]
        static void PrintSanjiao(int n)
        {
            int[][] arr2 = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arr2[i] = new int[n];
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                    {
                        arr2[i][j] = 1;
                        Console.Write("[" + arr2[i][j]);
                    }
                    else if (j == i)
                    {
                        arr2[i][j] = 1;
                        Console.Write("," + arr2[i][j] + "]");
                    }
                    else
                    {
                        arr2[i][j] = arr2[i - 1][j - 1] + arr2[i - 1][j];
                        Console.Write("," + arr2[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
