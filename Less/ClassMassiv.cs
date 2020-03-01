using System;
using static print_pause.View;

namespace Less
{
    class ClassMassiv
    {
        public static int ReshMass(int[] arr, int lengh)
        {
            int b = 0;

            for (int i = 0; i < lengh - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                {
                    b++;
                }
            }
            return b;
        }

    }
}
