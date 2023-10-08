using System;

public class PromptGenerator
{
    public string Prompt()
    {
        List<string> prompts = new List<string> {
            "What things am I grateful for today?",
            "What was the most exciting thing that happened to me today?",
            "Who was the most interesting person I interacted with today?",
            "What things did I do today or could I do to become the person I want?",
            "What did I do today to show my love for other people?",
            "How did I see the hand of the Lord in my life today?",
            "What was my favorite moment of the day?",
            "What was the strongest emotion I felt today?",
            "What things helped me get through a difficult time today?",
        };
        Random promptGenerator = new Random();
        int index = promptGenerator.Next(prompts.Count);
        string prompt = prompts[index];

        return prompt;
    }
}