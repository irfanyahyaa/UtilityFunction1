namespace NawadataDotNet2;

public class WordCounter
{
    public int WordCounterFunc(string sentence)
    {
        return sentence.Split(" ").Length;
    }
}