using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WrittingAssignment w1 = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine($"{m1.GetHomeworkList()}");
        Console.WriteLine("");
        Console.WriteLine($"{w1.GetWritingInformation()}");
    }
}