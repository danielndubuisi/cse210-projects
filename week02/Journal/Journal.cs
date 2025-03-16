// stores a list of journal entries
using System.IO;
public class Journal 
{
    // attributes
    public List<Entry> _entries = new List<Entry>();
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
        if (Path.GetExtension(file).ToLower() != ".csv")
        {
            Console.WriteLine("Error: The file must be type 'csv'!");
            return;
        }

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // escape commas and quotation marks
                string date = entry._date.Replace("\"", "\"\"");
                string promptText = entry._promptText.Replace("\"", "\"\"");
                string entryText = entry._entryText.Replace("\"", "\"\"");
                
                // save to the file
                outputFile.WriteLine($"\"{date}\",\"{promptText}\",\"{entryText}\"");
            }
        }
        Console.WriteLine("Journal saved to file!");
    }
    public void LoadFromFile(string file)
    {
        if (Path.GetExtension(file).ToLower() != ".csv")
        {
            Console.WriteLine("Error: The file must be type 'csv'!");
            return;
        }

        // read all file lines into a list
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            // split line parts
            string[] parts = line.Split(new string[] { "\",\"" }, StringSplitOptions.None);
            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0].Trim('"').Replace("\"\"", "\"");
                entry._promptText = parts[1].Replace("\"\"", "\"");
                entry._entryText = parts[2].Trim('"').Replace("\"\"", "\"");
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded from file!");
    }
}