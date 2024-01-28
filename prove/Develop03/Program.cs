using System;

class Program
{

    static string getRandomScripture()
    {

        Random randomGenerator = new Random();
        string filename = "data_scriptures.txt";

        List<string> lines = new List<string>();
    
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                
                lines.Add(line);
            }
        }
        
        int inx = randomGenerator.Next(0, lines.Count());

        Console.WriteLine(lines.Count());

        if (lines.Count() == 0){
            return "";
        }

        return lines[inx];
    }

    static void Main(string[] args)
    {

        // exceed requirement, using a file to get the scriptures and references   
        string randomLine = getRandomScripture();

        if (randomLine == "")
        {
            Console.WriteLine("Something wrong at data_scriptures.txt file");
            return;
        }

        string[] lineSplit = randomLine.Split("|");

        string[] referenceSplit = lineSplit[0].Split(",");

        string book = referenceSplit[0];
        int chapter = int.Parse(referenceSplit[1]);
        int verse = int.Parse(referenceSplit[2]);
        int endVerse = referenceSplit.Length == 4 ? int.Parse(referenceSplit[3]) : 0;

        Reference reference = new Reference(book, chapter, verse, endVerse);
        string scripText = lineSplit[1];
        
        Scripture scripture = new Scripture(reference, scripText);

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