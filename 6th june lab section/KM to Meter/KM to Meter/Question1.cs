using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an object of ConvertValues class
        ConvertValues converter = new ConvertValues();

        // Call the kilometerToMeter method
        converter.KilometerToMeter();

        Console.ReadLine();
    }
}

class ConvertValues
{
    public void KilometerToMeter()
    {
        Console.WriteLine("Enter the value in kilometers (km):");

        // Read the user input for kilometers
        string input = Console.ReadLine();

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
