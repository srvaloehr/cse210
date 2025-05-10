using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int startnumber = -1;

        while (startnumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when done.");
            string startgiv = Console.ReadLine();
            startnumber = int.Parse(startgiv);
            if (startnumber != 0)
            {
                numbers.Add(startnumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average:{average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number: {max}");
    }         
}