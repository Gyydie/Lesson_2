using System;
using System.IO;
using static print_pause.View;

namespace task_3
{
    class Array
    {
        int[] arr;

        public Array()
        {

        }

        public Array (int sizeArr, int firstEl, int step)
        {
            arr    = new int[sizeArr];
            arr[0] = firstEl;
            Print($" {arr[0]}");
            for (int i = 1; i < sizeArr; i++)
            {
                arr[i] = arr[i - 1] + step;

                Print($" {arr[i]}");
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }

        public int Inverse
        {
            set
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] * -1;
                    Print($" {arr[i]}");
                }
            }
        }

        public int Multi
        {
            set
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] * value;
                    Print($" {arr[i]}");
                }
            }
        }

        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int Max
        {
            get
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }
        }
    }
}
