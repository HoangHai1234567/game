using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            // Bước 1: In menu
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PrintRectangle();
                    break;

                case 2:
                    PrintSquareTriangle();
                    break;

                case 3:
                    PrintIsoscelesTriangle();
                    break;

                case 0:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please choose again.");
                    break;
            }

        } while (choice != 0);
    }

    // Bước 2: Hàm in hình chữ nhật
    static void PrintRectangle()
    {
        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Enter width: ");
        int width = int.Parse(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    // Bước 2: Hàm in các loại tam giác vuông
    static void PrintSquareTriangle()
    {
        Console.WriteLine("\nChoose corner position:");
        Console.WriteLine("1. Bottom-Left");
        Console.WriteLine("2. Top-Left");
        Console.WriteLine("3. Bottom-Right");
        Console.WriteLine("4. Top-Right");
        Console.Write("Enter your choice: ");

        int type = int.Parse(Console.ReadLine());
        Console.Write("Enter height of triangle: ");
        int height = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1: // Bottom-Left
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                break;

            case 2: // Top-Left
                for (int i = height; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                break;

            case 3: // Bottom-Right
                for (int i = 1; i <= height; i++)
                {
                    for (int j = 1; j <= height - i; j++)
                        Console.Write("  "); // in khoảng trắng

                    for (int k = 1; k <= i; k++)
                        Console.Write("* ");

                    Console.WriteLine();
                }
                break;

            case 4: // Top-Right
                for (int i = height; i >= 1; i--)
                {
                    for (int j = 1; j <= height - i; j++)
                        Console.Write("  "); // in khoảng trắng

                    for (int k = 1; k <= i; k++)
                        Console.Write("* ");

                    Console.WriteLine();
                }
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    // Bước 2: Hàm in tam giác cân
    static void PrintIsoscelesTriangle()
    {
        Console.Write("Enter height of isosceles triangle: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            // in khoảng trắng
            for (int j = 1; j <= height - i; j++)
                Console.Write("  ");

            // in dấu *
            for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
}
