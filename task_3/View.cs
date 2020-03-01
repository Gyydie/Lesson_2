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

        public static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }
    }
}
