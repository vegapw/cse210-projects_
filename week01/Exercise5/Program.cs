using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(displayWelcome());
        string username = promptUserName();
        int favoriteNumber, sqNumber;
        favoriteNumber = promptUserNumber();
        sqNumber = squareNumber(favoriteNumber);
        displayResult(username, sqNumber);
    }

    static string displayWelcome(){
        return "Welcome to the program!";
    }

    static string promptUserName(){
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int promptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int squareNumber(int number){
        return (number * number);
    }

    static void displayResult(string username, int squareNumber){
        Console.WriteLine($"{username}, the square of your number is {squareNumber}");
    }
}