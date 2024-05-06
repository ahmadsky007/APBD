using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int xam = FindMaxValue(numbers);
            Console.WriteLine("Maximum value: " + xam);
        }

        static int FindMaxValue(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array must not be empty");

            int xam = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > xam)
                    xam = arr[i];
            }
            return xam;
        }
    }
}
