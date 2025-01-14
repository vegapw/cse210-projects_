using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magic_n = int.Parse(Console.ReadLine());
        string again = "";
        do
        {
            Random random_n = new Random();
            int magic_n = random_n.Next(1,101);
            int guess_n, cont=0;
            string tries = "";
            Console.WriteLine("Guess the number!!");
            do {
                Console.Write("What is your guest? ");
                guess_n = int.Parse(Console.ReadLine());
                if (magic_n < guess_n){
                Console.WriteLine("Lower");
                } else if (magic_n > guess_n) {
                    Console.WriteLine("Higher");
                } else {
                    Console.WriteLine("You guess it!");
                }
                cont += 1;
            } while (magic_n != guess_n);
            if (cont > 1){
                tries = "times";
            } else {
                tries = "time";
            }
            Console.WriteLine($"It took you {cont} {tries} to guess the number.");
            cont = 0;
            tries = "";
            Console.Write("Do you want to play again?");
            again = Console.ReadLine();
        } while (again.ToLower() == "yes");
    }
}