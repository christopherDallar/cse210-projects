using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 4)
            {
                break;
            }

            switch (option)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "his activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                    breathingActivity.Run();

                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    break;
            }



        }
    }
}