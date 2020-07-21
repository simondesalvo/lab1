using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus  Room Detail Generator");

            Console.WriteLine("Would you like to enter room details? y/n");
            string answer = Console.ReadLine();
            while (answer == "y")
            {
                Console.Write("Enter Length ");

                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter width ");
                double width = double.Parse(Console.ReadLine());

                Console.Write("Enter height");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("Area " + (length * width));
                Console.WriteLine("Perimeter " + (length * 2 + width * 2));
                Console.WriteLine("Volume " + (length * width * height));

                Console.Write("Continue? (y/n)");
                answer = Console.ReadLine();
            };
            
            
            
         

        }
    }
}
