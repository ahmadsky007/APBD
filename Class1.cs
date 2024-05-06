using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int max = FindMaxValue(numbers);
            Console.WriteLine("Maximum value: " + max);
        }

        static int FindMaxValue(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array must not be empty");

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
    }
}
