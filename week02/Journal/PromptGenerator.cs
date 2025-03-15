// supplies random prompts whenever needed
public class PromptGenerator
{
    // attributes
    public List<string> prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"];

    // method
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(0, 5);
        return prompts[promptIndex];
    }
}