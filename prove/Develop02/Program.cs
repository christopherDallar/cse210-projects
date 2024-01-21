using System;

class Program
{
    static void Main(string[] args)
    {
        int option = -1;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (option != 5)
        {
            Console.WriteLine("");

            Console.WriteLine("Welcome to Journal Program!");
            Console.WriteLine("Please select one of the following choices");

            Console.WriteLine("");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("");

            Console.Write("What would you like to do? ");

            // Exceed requirements retry when user type invalid option
            string optionEntry = Console.ReadLine();
            string[] validOptions = {"1", "2", "3", "4", "5"};

            // Inspired from python not in statement
            if ( !validOptions.Contains(optionEntry))
            {
                Console.WriteLine("Opción no válida!");
                Console.WriteLine("");
                continue;
            }
            // end Exceed requirements

            option = int.Parse(optionEntry);
            string fileName = "";

            switch (option)
            {
                case 1:
                    string promptText = promptGenerator.GetRandomPrompt();
                    
                    Console.WriteLine(promptText);

                    string entryText = Console.ReadLine();
                    DateTime date = new DateTime(); // Exceed requirement i used the DateTime Object

                    Entry entry = new Entry();
                    entry._promptText = promptText;
                    entry._entryText = entryText;
                    entry._date = date.ToString();

                    journal.AddEntry(entry);

                    break;
                case 2:
                    journal.DisplayAll();

                    break;
                case 3:
                    Console.WriteLine("Type the filename: ");
                    fileName = Console.ReadLine();

                    journal.LoadFromFile(fileName);

                    break;
                case 4:
                    Console.WriteLine("Type the filename: ");
                    fileName = Console.ReadLine();

                    journal.SaveToFile(fileName);

                    break;
                case 5:
                    Console.WriteLine("Bye!");
                    break;
            }

        }
    }
}