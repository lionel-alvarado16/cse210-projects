using System;

public class PromptGenerator
{
    public string Prompt()
    {
        List<string> prompts = new List<string> {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random promptGenerator = new Random();
        int index = promptGenerator.Next(prompts.Count);
        string prompt = prompts[index];

        return prompt;
    }
}