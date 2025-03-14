// stores a list of journal entries
public class Journal 
{
    // attributes
    public List<Entry> _entries = [];
    // methods
    public void AddEntry(Entry newEntry)
    {
        Console.WriteLine($"Your new entry is {newEntry}");
    }
    public void DisplayAll()
    {
        Console.WriteLine("display all");
    }
    public void SaveToFile(string file)
    {
        Console.WriteLine("new entry");
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("new entry");
    }
}