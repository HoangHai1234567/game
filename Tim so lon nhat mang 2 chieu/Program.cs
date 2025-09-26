using System;

namespace LARGEST_NUMBER_IN_2_DIMENSION_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap so hang
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            //Nhap so cot
            Console.WriteLine("Enter the number of columns:");
            int cols = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, cols];

            //Nhap cac phan tu trong mang
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            {
                
            }
            int largestNumber = FindLargestNumber(array);
            Console.WriteLine($"The largest number in the array is: {largestNumber}");
        }
        static int FindLargestNumber(int[,] array)
        {
            int largest = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > largest)
                    {
                        largest = array[i, j];
                    }
                }
            }
            return largest;
        }
    }
}