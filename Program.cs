using System;

namespace InsertionSortPractice
{
    class Program
    {
        public static void Insertionn(int[] arr)
        {
            int n = arr.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = arr[i];
                int j =i-1;
                while (j >= 0 && arr[j] > temp)

                  {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }
        }
        static void Main()
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            Program.Insertionn(array);
            for (int i = 0; i < array.Length; i++)
            Console.WriteLine(" " + array[i]);
        }

    }
}
