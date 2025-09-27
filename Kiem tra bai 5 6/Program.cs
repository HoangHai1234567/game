using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    // Thuoc tinh
    public string Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }

    // Constructor
    public Student(string id, string name, double score)
    {
        Id = id;
        Name = name;
        Score = score;
    }

    // Display
    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Score: {Score}");
    }
}

class Program
{
    // Hàm nhập danh sách sinh viên
    static List<Student> NhapDanhSach()
    {
        List<Student> list = new List<Student>();
        Console.Write("Nhap so luong sinh vien: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin sinh vien thu {i + 1}:");

            Console.Write("Nhap ID: ");
            string id = Console.ReadLine();

            Console.Write("Nhap ten: ");
            string name = Console.ReadLine();

            Console.Write("Nhap diem: ");
            double score = Convert.ToDouble(Console.ReadLine());

            list.Add(new Student(id, name, score));
        }

        return list;
    }

    // Hàm in danh sách sinh viên
    static void InDanhSach(List<Student> list)
    {
        Console.WriteLine("\n=== Danh sach sinh vien ===");
        foreach (var s in list)
        {
            s.Display();
        }
    }

    // Hàm tìm sinh viên có điểm cao nhất
    static void TimDiemCaoNhat(List<Student> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("Danh sach rong!");
            return;
        }

        double maxScore = list.Max(s => s.Score);
        Console.WriteLine($"\n=== Sinh vien co diem cao nhat ({maxScore}) ===");
        foreach (var s in list.Where(s => s.Score == maxScore))
        {
            s.Display();
        }
    }

    // Hàm tìm tất cả sinh viên có điểm >= 8
    static void TimSinhVienDiemCao(List<Student> list)
    {
        Console.WriteLine("\n=== Sinh vien co diem >= 8 ===");
        var ds = list.Where(s => s.Score >= 8).ToList();

        if (ds.Count == 0)
        {
            Console.WriteLine("Khong co sinh vien nao.");
        }
        else
        {
            ds.ForEach(s => s.Display());
        }
    }

    // Hàm tìm sinh viên theo tên (không phân biệt hoa thường)
    static void TimTheoTen(List<Student> list)
    {
        Console.Write("\nNhap ten sinh vien can tim: ");
        string nameSearch = Console.ReadLine().ToLower();

        var ds = list.Where(s => s.Name.ToLower().Contains(nameSearch)).ToList();

        if (ds.Count == 0)
            Console.WriteLine("Khong tim thay sinh vien.");
        else
        {
            Console.WriteLine("\n=== Ket qua tim kiem ===");
            ds.ForEach(s => s.Display());
        }
    }

    static void Main(string[] args)
    {
        // Nhập danh sách
        List<Student> students = NhapDanhSach();

        // In danh sách
        InDanhSach(students);

        // Tìm sinh viên điểm cao nhất
        TimDiemCaoNhat(students);

        // Tìm sinh viên có điểm >= 8
        TimSinhVienDiemCao(students);

        // Tìm sinh viên theo tên
        TimTheoTen(students);

        Console.WriteLine("\n--- Ket thuc chuong trinh ---");
    }
}
