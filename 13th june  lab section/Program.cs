using System;

namespace CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues calculator = new FindValues();
            double area = calculator.FindArea(radius);
            double circumference = calculator.FindCircumference(radius);

            Console.WriteLine("Area of the circle: " + area);
            Console.WriteLine("Circumference of the circle: " + circumference);

            Console.ReadLine();
        }
    }

    class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
    }
