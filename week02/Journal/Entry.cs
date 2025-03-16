// represents a single journal entry
public class Entry
{
    // attribute
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    // method
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText} |\n");
    }
}