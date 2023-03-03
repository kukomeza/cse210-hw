class Journal
{
    List<Entry> entries = new List<Entry>();

    public Journal()
    {
        
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry()
    {
        PromptGenerator promptGen = new PromptGenerator();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    public void SaveToCSV()
    {
        Console.WriteLine("Name of file to save:");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.getEntryAsCSV()); 
            }
        }
    }

    public void LoadFromCSV()
    {
        Console.WriteLine("Name of file to load:");
        string _fileName = Console.ReadLine();

        List<string> records = System.IO.File.ReadLines(_fileName).ToList();
        foreach (string record in records)
        {
            string[] splitString = record.Split ('|');
            Entry entry =new Entry(splitString[0], splitString[1], splitString[2]);
            entries.Add(entry);
        }

    }
}