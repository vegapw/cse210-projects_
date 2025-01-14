using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.AddPrompt("Who was the most interesting person I interacted with today?");
        promptGenerator.AddPrompt("What was the best part of my day?");
        promptGenerator.AddPrompt("How did I see the hand of the Lord in my life today?");
        promptGenerator.AddPrompt("What was the strongest emotion I felt today?");
        promptGenerator.AddPrompt("If I had one thing I could do over today, what would it be?");
        string fileName = "";

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                Entry entry = new Entry();
                entry.SetPrompt(promptGenerator.GetRandomPrompt());
                Console.WriteLine($"{entry.GetPrompt()}");
                entry.SetResponse(Console.ReadLine());
                entry.SetDate(DateTime.Now);
                journal.AddEntry(entry);
                break;
                case 2:
                journal.DisplayAll();
                break;
                case 3:
                Console.Write("Please enter the file name to load: ");
                fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                break;
                case 4:
                Console.Write("Please enter the file name to save: ");
                fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                break;
                case 5:
                Console.WriteLine("Bye");
                break;
                default:
                Console.WriteLine("Wrong option.");
                break;
            }
        } while (option != 5);
    }
}