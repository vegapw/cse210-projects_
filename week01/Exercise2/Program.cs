using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type your grade: ");
        int percentage = int.Parse(Console.ReadLine());
        string letter = "";
        if (percentage >= 90) {
            letter = "A";
        } else if (percentage >= 80) {
            letter = "B";
        } else if (percentage >= 70) {
            letter = "C";
        } else if (percentage >= 60) {
            letter = "D";
        } else if (percentage < 60) {
            letter = "F";
        } else {
            Console.WriteLine("Wrong percentage, try again!!");
        }

        string sign = "";
        int last_digit = percentage % 10 ;
        int first_digit = percentage / 10;
        if (last_digit >= 7) {
            if (first_digit != 9 && first_digit > 5) {
                sign = "+";
            }
        } else if ( last_digit < 3){
            if (first_digit > 5){
                sign = "-";
            }
        }

        if (letter != "")
        {
            Console.WriteLine($"Your grade is {letter}{sign}");
        }

        if (letter != "D" && letter != "F" && letter != "")
        {
            Console.WriteLine("Congratulations, you passed the course!!");
        } else {
            Console.WriteLine("Sorry, try again next time!!");
        }
    }
}