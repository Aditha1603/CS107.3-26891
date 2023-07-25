using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an object of ConvertValues class
        ConvertValues converter = new ConvertValues();

        // Prompt the user to enter the kilometers value
        Console.WriteLine("Enter the value in kilometers (km):");
        string input = Console.ReadLine();

        // Call the kilometerToMeter method and pass the user input as a parameter
        converter.KilometerToMeter(input);

        Console.ReadLine();
    }
}

class ConvertValues
{
    public void KilometerToMeter(string input)
    {
        // Convert the input string to double
        if (double.TryParse(input, out double kilometers))
        {
            // Convert kilometers to meters
            double meters = kilometers * 1000;

            // Display the result
            Console.WriteLine($"{kilometers} kilometers is equal to {meters} meters.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value.");
        }
    }
}
