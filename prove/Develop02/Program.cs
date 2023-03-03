using System;

class Program
{
    static void Main(string[] args)
    {
        
        // create menu user input variables
        int userInput =0;
        Journal journal = new Journal();
        
        // While user input is not 5
        while(userInput !=5)
        {
            Console.WriteLine("Please select one of the following choices: \n" + 
                                "1.-Write\n" + 
                                "2.-Display\n" +
                                "3.-Load\n"+
                                "4.-Save\n"+
                                "5.-Quit\n"+
                                "What would you like to do?");
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    journal.CreateJournalEntry();
                    break;
                case 2:
                    journal.DisplayJournalEntries();
                    break;
                case 3:
                    journal.LoadFromCSV();
                    break;
                case 4:
                    journal.SaveToCSV();
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("End");
    }
}