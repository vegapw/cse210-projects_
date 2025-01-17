using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, text);
        bool ind = true;
        string outPutText = "", inputText = "";
        do
        {
            Console.Clear();
            outPutText = scripture.GetDisplayText();
            Console.WriteLine();
            Console.WriteLine(outPutText);
            Console.WriteLine();
            Console.WriteLine("Press enter  to continue or type 'quit' to finish: ");
            inputText = Console.ReadLine();
            if (inputText.ToLower().Equals("quit") || scripture.IsCompletelyHidden())
            {
                ind = false;
            } else {
                scripture.HideRandomWords(3);
            }
        } while (ind);
    }
}