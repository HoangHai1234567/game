using System;

namespace XOA_PHAN_TU_KHOI_MANG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap so luong phan tu mang
            Console.Write("Nhap so luong phan tu mang: ");
            int n = int.Parse(Console.ReadLine());

            //Khoi tao mang
            int[] array = new int[n];

            //Nhap cac phan tu mang
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            //Nhap phan tu can xoa
            Console.Write("Nhap phan tu can xoa: ");
            int number = int.Parse(Console.ReadLine());

            //Xoa phan tu khoi mang
            int removed = DeleteAll(ref array, number);

            if (removed == 0)
            {
                Console.WriteLine("Khong tim thay phan tu can xoa.");
            }
            else
            {
                Console.WriteLine($"Da xoa {removed} phan tu.");
                Console.WriteLine("Mang sau khi xoa:");
                foreach (var item in array)
                    Console.Write(item + " ");
            }

        }

        static int DeleteAll(ref int[] array, int number)
        {
            int write = 0;      // vị trí ghi
            int removed = 0;    // đếm số phần tử bị xóa

            for (int read = 0; read < array.Length; read++)
            {
                if (array[read] != number)
                {
                    array[write++] = array[read]; // giữ lại phần tử khác number
                    // neu khong dung write ++ co the viet la: array[write] = array[read]; write++;
                }
                else
                {
                    removed++; // gặp phần tử cần xóa
                }
            }

            if (removed > 0)
            {
                Array.Resize(ref array, write); // co mảng còn phần giữ lại
            }

            return removed; // trả về số phần tử đã xóa
        }
    }
}