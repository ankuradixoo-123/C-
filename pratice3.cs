using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice (1/2/3/4): ");
        
        
        int choice = Convert.ToInt32(Console.ReadLine());
        
        
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        
        double result = 0;
        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"The result of addition is: {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"The result of subtraction is: {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"The result of multiplication is: {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"The result of division is: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid operation.");
                break;
        }
        
    
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
