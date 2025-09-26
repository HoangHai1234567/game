using System;

namespace TINH_TONG_DUONG_CHEO_CHINH_VUONG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap kich thuoc ma tran vuong (n x n): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Nhap cac phan tu cua ma tran: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Phan tu [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //in ra ma tran
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Tinh tong duong cheo chinh
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i]; // Tong duong cheo chinh
            }
            Console.WriteLine($"Tong duong cheo chinh cua ma tran la: {sum}");
        }
    }
}