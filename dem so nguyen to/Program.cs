using System;

class Program
{
    static void Main(string[] args)
    {
        int dem; // đếm số ước của mỗi số

        Console.WriteLine("Danh sách các số nguyên tố nhỏ hơn 100:");

        // Bước 1: Duyệt các số từ 2 đến 100
        for (int i = 2; i < 100; i++)
        {
            dem = 0; // đặt lại số đếm cho mỗi số i

            // Bước 2: Đếm số ước của i
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    dem++;
                }
            }

            // Nếu chỉ có đúng 2 ước (1 và chính nó) → số nguyên tố
            if (dem == 2)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine(); // xuống dòng sau khi in xong
    }
}
