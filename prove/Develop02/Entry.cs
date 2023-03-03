class Entry
{
    string date, prompt, response;

    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt =_prompt;
        response =_response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine(string.Format("{0} - {1} \n{2}\n", date, prompt, response));
    }

    internal string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, response);
    }
}