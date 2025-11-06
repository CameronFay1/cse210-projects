using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {
        Console.WriteLine("Saving file....\n");
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {  
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine(entry.DisplayForFile());
        }
        }
    }


    public void LoadFile(string fileName)
    {
        Console.WriteLine("Opening file...\n");
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries = [];
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText= parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
        File.WriteAllText(fileName, "");
    }

}