public class Entry
{
    public string _date = DateTime.Now.ToString();
    public string _promptText;
    public string _entryText;


    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}\n");
    }
    public string DisplayForFile()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

}