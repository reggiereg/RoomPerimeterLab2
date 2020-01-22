using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            char option = 'y';
            while (option != 'n')
            {
                decimal length, width, perimeter, area, height;
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator");
                Console.WriteLine("Please enter the Length: ");
                length = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Width: ");
                width = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Height: ");
                height = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Area: {length * width}\nPerimeter: {length * 2 + width *2}\nVolume: {length*width*height}");
                Console.WriteLine("\n");
                Console.WriteLine("Would you like to continue? (y/n)");
                option = char.Parse(Console.ReadLine());
            }
        }
    }
}
