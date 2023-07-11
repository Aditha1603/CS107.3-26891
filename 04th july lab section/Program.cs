using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        ArrayHandler arrayHandler = new ArrayHandler();
        int[] array = arrayHandler.CreateArrayWithZeros(size);

        Console.WriteLine("Enter values for the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("0");
        }

        Console.WriteLine("Final array:");
        foreach (int element in array)
        {
            Console.Write($"{element} ");
        }
    }
}

class ArrayHandler
{
    public int[] CreateArrayWithZeros(int size)
    {
        return new int[size];
    }
}
