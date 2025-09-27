using System;
using System.Net.Http.Headers;
using System.Runtime;

namespace TEST
{
    class Program
    {
        //bai 1
        //static void Judge(double input)
        //{
        //    switch (input)
        //    {
        //        case < 0:
        //            Console.WriteLine("Nhap diem tu 0 den 10");
        //            break;

        //        case < 5:
        //            Console.WriteLine("Truot");
        //            break;

        //        case <= 6.9:
        //            Console.WriteLine("Trung binh");
        //            break;

        //        case <= 8.4:
        //            Console.WriteLine("Kha");
        //            break;

        //        case <= 10:
        //            Console.WriteLine("Gioi");
        //            break;
        //        case > 10:
        //            Console.WriteLine("Nhap diem tu 0 den 10");
        //            break;
        //    }
        //}







        //bai 2
        //static double[] Calculator(double[] n)
        //{
        //    double avg = 0;
        //    double high = n[0];
        //    double low = n[0];

        //    for (int i = 0; i < n.Length; i++)
        //    {
        //        avg += n[i];
        //        if (n[i] > high)
        //        {
        //            high = n[i];
        //        }
        //        if (n[i] < low)
        //        {
        //            low = n[i];
        //        }
        //    }
        //    avg /= n.Length;
        //    double[] result = { avg, high, low };
        //    return result;
        //}







        //bai 3
        //nhap danh sach
        //static List<string> NhapDanhSach()
        //{
        //    List<string> students = new List<string>();
        //    Console.WriteLine("Nhap danh sach ten sinh vien (nhap 'end' de dung):");

        //    while (true)
        //    {
        //        Console.Write("Nhap ten: ");
        //        string name = Console.ReadLine();

        //        if (name.ToLower() == "end")
        //            break;

        //        if (!string.IsNullOrWhiteSpace(name))
        //            students.Add(name);
        //    }

        //    return students;
        //}

        ////in danh sach
        //static void InDanhSach(List<string> students)
        //{
        //    Console.WriteLine("\nDanh sach sinh vien:");
        //    foreach (var s in students)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        ////Tim ten dai nhat
        //static string TimTenDaiNhat(List<string> students)
        //{
        //    if (students.Count == 0) return null;

        //    string longest = students[0];
        //    foreach (var s in students)
        //    {
        //        if (s.Length > longest.Length)
        //        {
        //            longest = s;
        //        }
        //    }
        //    return longest;
        //}








        //bai 4
        //Them sinh vien
        static void ThemSinhVien(Dictionary<string, string> ds)
        {
            Console.Write("Nhap ma sinh vien: ");
            string ma = Console.ReadLine();

            if (ds.ContainsKey(ma))
            {
                Console.WriteLine("Ma sinh vien da ton tai!");
                return;
            }

            Console.Write("Nhap ten sinh vien: ");
            string ten = Console.ReadLine();

            ds[ma] = ten;
            Console.WriteLine("Da them sinh vien thanh cong!");
        }

        //Tim sinh vien theo ma
        static void TimSinhVien(Dictionary<string, string> ds)
        {
            Console.Write("Nhap ma sinh vien can tim: ");
            string ma = Console.ReadLine();

            if (ds.ContainsKey(ma))
            {
                Console.WriteLine($"Ten sinh vien: {ds[ma]}");
            }
            else
            {
                Console.WriteLine("Khong tim thay");
            }
        }

        //In danh sach sinh vien
        static void InDanhSach(Dictionary<string, string> ds)
        {
            Console.WriteLine("\nDanh sach sinh vien:");
            foreach (var sv in ds)
            {
                Console.WriteLine($"Ma: {sv.Key}  -  Ten: {sv.Value}");
            }
        }



        static void Main(string[] args)
        {
            //bai 1
            //while (true)
            //{
            //    Console.Write("Nhap diem: ");
            //    double diem = Convert.ToDouble(Console.ReadLine());
            //    Judge(diem);
            //    Console.WriteLine("Ban co muon nhap tiep khong?   Y   N");
            //    string choice = Console.ReadLine();
            //    if (choice == "N" || choice == "n")
            //    {
            //        break;
            //    }
            //    if (choice == "Y" || choice == "y")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nhap sai cu phap");
            //        break;
            //    }
            //}






            //bai 2
            //Console.Write("Nhap so luong phan tu: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double[] arr = new double[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Nhap phan tu thu {i + 1}: ");
            //    arr[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //double [] result = Calculator(arr);
            //Console.WriteLine($"Average: {result[0]}, High: {result[1]}, Low: {result[2]}");





            //bai 3
            //List<string> danhSach = NhapDanhSach();

            //InDanhSach(danhSach);       

            //string tenDaiNhat = TimTenDaiNhat(danhSach);      
            //if (tenDaiNhat != null)
            //{
            //    Console.WriteLine($"\nTen sinh vien dai nhat: {tenDaiNhat}");
            //}
            //else
            //{
            //    Console.WriteLine("\nKhong co sinh vien nao trong danh sach!");
            //}



            //bai 4
            Dictionary<string, string> sinhVien = new Dictionary<string, string>;
            while (true)
            {
                Console.WriteLine("\n    MENU    ");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Tim sinh vien theo ma");
                Console.WriteLine("3. In danh sach sinh vien");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ThemSinhVien(sinhVien);
                        break;
                    case "2":
                        TimSinhVien(sinhVien);
                        break;
                    case "3":
                        InDanhSach(sinhVien);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long thu lai.");
                        break;
                }
            }
        }

    }
}