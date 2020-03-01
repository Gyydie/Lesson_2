using System;

namespace print_pause
{
    public class View
    {
        public static void Print (object value, bool isNewLine = true)
        {
            if (isNewLine)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.Write(value);
            }
        }

        public static void Pause ()
        {
            Console.ReadKey();
        }

        public static void PrintMatrix(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Print($" {array[i, j]}", false);
                }

                Print(" ");
            }
        }
    }
}
