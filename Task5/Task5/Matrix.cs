using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class Matrix
    {
        public static int[,] Add(int[,] array1, int[,] array2)
        {
            if (array1.GetLength(0) != array2.GetLength(1)
                || array1.GetLength(1) != array2.GetLength(1))
                return null;

            int rows = array1.GetLength(0);
            int columns = array1.GetLength(1);
            int[,] newArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newArray[i, j] = array1[i, j] + array2[i, j];
                }
            }

            return newArray;
        }

        public static String ToString(int[,] array)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    s.Append(array[i, j]);
                    if (j != array.GetLength(1) - 1)
                        s.Append(" ");
                }
                s.AppendLine();
            }

            return s.ToString();
        }

        public static int[,] FromString(String s)
        {
            String[] lines = s.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            String[][] numbers = lines.Select(line => line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)).ToArray();

            // suppose that input is rectangular
            int rows = numbers.Length;
            int columns = numbers[0].Length;
            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(numbers[i][j]);
                }
            }

            return array;
        }

        public static int[,] CreateRandom2DArray(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            Random r = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = r.Next(10);
                }
            }

            return array;
        }

        public static int?[,] ConvertElementsToNullable(this int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int?[,] nullable = new int?[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nullable[i, j] = (int?)array[i, j];
                }
            }

            return nullable;
        }

        public static int[,] ConvertElementsFromNullable(this int?[,] nullable)
        {
            int rows = nullable.GetLength(0);
            int columns = nullable.GetLength(1);
            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = (nullable[i, j] ?? 0);
                }
            }

            return array;
        }
    }
}
