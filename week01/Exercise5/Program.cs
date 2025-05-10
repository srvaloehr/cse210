using System;

class Program
{
    static void Main(string[] args)
    {
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int favoriteNumber = PromptUserNumber();

            int squared = SquareNumber(favoriteNumber);
            DisplayResult(userName, squared);
        }
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplayWelcome()
        {
            Console.Write("Welcome to the program.");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter you favorite number. ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
        static int SquareNumber(int number)
        {
            return number * number;

        }
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your numer is {squaredNumber}");
        }
        static void Main(string[] args)
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int favoriteNumber = PromptUserNumber();

            int squared = SquareNumber(favoriteNumber);
            DisplayResult(userName, squared);
        }
    }
}