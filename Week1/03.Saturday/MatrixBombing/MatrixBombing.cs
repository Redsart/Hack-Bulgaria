using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixBombing
{
    class MatrixBombing
    {
        static void Main(string[] args)
        {
            int[,] m=new int[3,4] { {1, 2,  3,  4},
                                    {5, 6,  7,  8},
                                    {9, 10, 11, 12}
                                                    };
            Console.WriteLine("You take {0} damage!",MatrixxBombing(m));
        }

        private static int MatrixxBombing(int[,] m)
        {
            int row = 0;
            int col = 0;
            int bombRow=0;
            int bombCol=0;
            int sumAll = 0;
            int bomb = 7;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                row++;
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    sumAll += m[i, j];
                    col++;
                    if (m[i,j]==bomb)
                    {
                        bombRow = row;
                        bombCol = col/row;
                    }
                }
            }
            int oldDamage = 0;
            for (int i = 0; i <= m[bombRow-1,bombCol-1]; i++)
            {
                oldDamage += i;
            }

            int result = sumAll - bomb - oldDamage;
            return result;
        }
    }
}
