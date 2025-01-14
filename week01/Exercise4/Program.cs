using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int n, sum=0, largest=0, smallest=0;
        double average=0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            if (n != 0){
                numbers.Add(n);
            }
        } while (n != 0);
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
            if (number > 0 && smallest == 0)
            {
                smallest = number;
            }
            if (smallest > number && number > 0)
            {
                smallest = number;
            }
        }
        int divisor = 1;
        if (numbers.Count > 0)
        {
            divisor = numbers.Count;
        }
        average = ((double)sum)/divisor;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted List is: ");
        numbers.Sort();
        foreach (int s in numbers)
        {
            Console.WriteLine($"{s}");
        }
    }
}