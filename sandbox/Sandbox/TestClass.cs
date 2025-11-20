using System.Data;

public class TestClass
{
    public int _one;
    public int _two;
    public string _word;
    public TestClass(int one,int two,string word)
    {
        _one = one;
        _two = two;
        _word = word;
    }
    public override string ToString()
    {
        return _one + "/" + _two + " " + _word;
    }
}