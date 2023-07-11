using System;

public class CalculateValues
{
    public int Addition(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Division(int num1, int num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: Division by zero!");
            return 0;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CalculateValues calculator = new CalculateValues();

        Console.WriteLine("Enter two numbers:");
        Console.Write("Number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the operation you want to perform:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        int result = 0;
        string operation = "";

        switch (choice)
        {
            case 1:
                result = calculator.Addition(num1, num2);
                operation = "Addition";
                break;
            case 2:
                result = calculator.Subtraction(num1, num2);
                operation = "Subtraction";
                break;
            case 3:
                result = calculator.Multiplication(num1, num2);
                operation = "Multiplication";
                break;
            case 4:
                result = calculator.Division(num1, num2);
                operation = "Division";
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        Console.WriteLine("----------------------------");
        Console.WriteLine("Operation: " + operation);
        Console.WriteLine("Result: " + result);
    }
}
