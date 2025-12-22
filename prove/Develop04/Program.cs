using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area", 0);
        ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0);

        int choice;
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.RunActivity();
                    breathingActivity.DisplayEndingMessage();
                    break;
                }
                case 2:
                {
                    reflectionActivity.DisplayStartingMessage();
                    reflectionActivity.RunActivity();
                    reflectionActivity.DisplayEndingMessage();
                    break;
                }
                case 3:
                {
                    listingActivity.DisplayStartingMessage();
                    listingActivity.RunActivity();
                    listingActivity.DisplayEndingMessage();
                    break;
                }
                default:
                {
                    if (choice !=4)
                    {
                        Console.WriteLine("Not a valid choice");
                    }
                    break;
                }
            };

        }while (choice != 4);
    }
}