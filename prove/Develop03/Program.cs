using System;

class Program
{ //To exceed requirements, I added a a library of scriptures rather than just one scripture.
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture("John 3:16","For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life"),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture("Matthew 22:37-38", "Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind; This is the first and great commandment."), 
            new Scripture("Exodus 20:12", "Honour thy father and thy mother: that thy days may be long upon the land which the Lord thy God giveth thee.")

        };
        
        Random random = new Random();
        int number = random.Next(scriptures.Count);
        
        Scripture scripture = scriptures[number];
        scripture.GetRenderedText();
        string action =""; 
       
        while(action != "quit")
        {
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            action = Console.ReadLine();
            if (action == "")
            {
                scripture.HideWords();
                Console.Clear();
                scripture.GetRenderedText();
            }
            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }
            
        }
    }
}