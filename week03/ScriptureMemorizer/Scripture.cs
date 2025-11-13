using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class Scripture
{
    private List<string> _words = new List<string>();
    private int _count;
    private int _amount;
    public Scripture()
    {
        
    }
    public Scripture(string text)
    {

        string clean = Regex.Replace(text, @"\s+", " "); 
        string[] Words = clean.Trim().Split(" ");
        

        foreach (string i in Words)
        {
            _words.Add(i);
        }
    }
    public void HideRandomWords()
    {
        _amount = 3;
        for (int i = 0; i < _amount; i++)
        {
            Random random = new Random();
            int number = random.Next(_words.Count());
            Word word = new Word(_words[number]);
            string enptyString = word.Hide();
            if (_words[number] != enptyString)
            {
                _count += 1;
            }
            else if (_words[number] == enptyString)
            {
                _amount += 1;
            }
            _words[number] = enptyString;
            if (i == 100)
            {
                break;
            }
        }
    }
    public bool GetFullClearAmount()
    {
        if (_count >= _words.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void GetDisplayText()
    {
        foreach (string i in _words)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");
    }
}