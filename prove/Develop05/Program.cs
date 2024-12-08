using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            ListingActivity listingActivity = new ListingActivity();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    breathingActivity.Start();
                }
                else if (choice == "2")
                {
                    reflectingActivity.Start();
                }
                else if (choice == "3")
                {
                    listingActivity.Start();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Pause(2);
                }
            }
        }

        static void Pause(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
    }
}
