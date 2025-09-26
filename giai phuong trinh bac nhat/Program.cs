using System;

class LinearEquationResolver
{
    static void Main(string[] args)
    {
        // Bước 1: Thông báo chức năng
        Console.WriteLine("Linear Equation Resolver");
        Console.WriteLine("Given an equation as 'a * x + b = 0', please enter constants:");

        // Bước 2: Nhập giá trị a và b
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Bước 3 + 4: Xử lý và tìm nghiệm
        if (a != 0)
        {
            double solution = -b / a;
            Console.WriteLine($"The solution is: {solution}");
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine("The solution is all x! (Phương trình có vô số nghiệm)");
            }
            else
            {
                Console.WriteLine("No solution! (Phương trình vô nghiệm)");
            }
        }
    }
}