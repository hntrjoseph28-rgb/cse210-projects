using System;

class Program
{
    static Journal _journal = new Journal();
    static PromptGenerator _promptGen = new PromptGenerator();

    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                WriteEntry();
            }
            else if (choice == "2")
            {
                Display();
            }
            else if (choice == "3")
            {
                Load();
            }
            else if (choice == "4")
            {
                Save();
            }
            else if (choice == "5")
            {
                quit = true;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

    static void WriteEntry()
    {
        string prompt = _promptGen.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        _journal.AddEntry(date, prompt, response);
    }

    static void Display()
    {
        _journal.DisplayAll();
    }

    static void Save()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        _journal.SaveToFile(filename);
    }

    static void Load()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        _journal.LoadFromFile(filename);
    }
}
