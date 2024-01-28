using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scrip_text = "Trust       in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, scrip_text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");

            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string option = Console.ReadLine();

            if (option == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            
            scripture.HideRandomWords(2);
        }
    }
}