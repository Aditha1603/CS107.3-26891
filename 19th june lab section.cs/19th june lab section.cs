
using System;

class ArrayOperations
{
    public static int FindMinimum(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    public static int FindMaximum(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }

    public static double FindAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return (double)sum / array.Length;
    }

    public static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];
        int index = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversedArray[index] = array[i];
            index++;
        }
        return reversedArray;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int minimum = ArrayOperationsh .FindMinimum(numbers);
        int maximum = ArrayOperations.FindMaximum(numbers);
        double average = ArrayOperations.FindAverage(numbers);
        int[] reversedArray = ArrayOperations.ReverseArray(numbers);

        Console.WriteLine($"Minimum value: {minimum}");
        Console.WriteLine($"Maximum value: {maximum}");
        Console.WriteLine($"Average value: {average}");
        Console.WriteLine("Reversed array: ");
        foreach (int num in reversedArray)
        {
            Console.Write(num + " ");
        }
    }
}



