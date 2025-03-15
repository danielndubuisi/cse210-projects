// stores a list of journal entries
public class Journal 
{
    // attributes
    public List<Entry> _entries = [];
    // methods
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
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