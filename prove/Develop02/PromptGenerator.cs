class PromptGenerator 
{
    List<string> prompt = new List<string>();

    public PromptGenerator()
    {
 
    }   

    public string GetRandomPrompt()
    {
        prompt.Add("Write about what your perfect day would look like.");
        prompt.Add("Name 3 things that make you smile.");
        prompt.Add("What does your ideal morning look like?");
        prompt.Add("Describe a moment in your life that you will never forget.");
        prompt.Add("List your three favorite hobbies, and what you love about each of them.");
        Random randomPrompt = new Random();

        return prompt[randomPrompt.Next(0,5)];
    }
}