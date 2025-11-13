public class Word
{
    private string _text;
    

    public Word(string text)
    {
        _text = text;

    }
    public string Hide()
    {
        string hideWord = "";

        foreach (int i in _text)
        {
            hideWord += "_";
        }
        _text = hideWord;
        return hideWord;     
    }
    public void Show()
    {
        Console.WriteLine(_text);
    }
    public string GetDisplayText()
    {
        return _text;
    }
}