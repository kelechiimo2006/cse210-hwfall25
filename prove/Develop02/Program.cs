using System;

class Program
{
    static void Main(string[] args)
    {
        Journal Journal = new Journal();
        Console.WriteLine("Welcome to the journal Program");
        int choice;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Entry/Entries");
            Console.WriteLine("4. Load Entry/Entries");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");
            Console.Write("What is your selection: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    Journal.AddEntry();
                    break;
                }
                case 2:
                {
                    Journal.DisplayEntries();
                    break;
                }
                case 3:
                {
                    Journal.SaveEntry();
                    break;
                }
                case 4:
                {
                    Journal.LoadEntry();
                    break;
                }
                default:
                {
                    if (choice !=5)
                    {
                        Console.WriteLine("Not a valid choice");
                    }
                    break;
                }
            };

        }while (choice != 5);
        
        
    }
}