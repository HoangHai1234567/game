using System;

class BMICalculator
{
    static void Main(string[] args)
    {
        // Bước 1: Khai báo biến
        double height;
        double weight;

        // Bước 2: Nhập dữ liệu từ bàn phím
        Console.WriteLine("Please enter your height (in meters): ");
        height = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your weight (in kilograms): ");
        weight = double.Parse(Console.ReadLine());

        // Bước 3: Tính chỉ số BMI và làm tròn kết quả
        double bmi = weight / Math.Pow(height, 2);
        bmi = Math.Round(bmi, 1); // làm tròn 1 chữ số thập phân

        // Bước 4: Hiển thị chỉ số và phân loại kết quả
        Console.Write("BMI: " + bmi);

        if (bmi < 18.5)
            Console.WriteLine(" - Underweight");
        else if (bmi < 25.0)
            Console.WriteLine(" - Normal");
        else if (bmi < 30.0)
            Console.WriteLine(" - Overweight");
        else
            Console.WriteLine(" - Obese");
    }
}
