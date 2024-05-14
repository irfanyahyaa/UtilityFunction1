namespace NawadataDotNet2;

public class MostAppearChar
{
    public char MostAppearCharFunc(string word)
    {
        string loweredWord = word.ToLower();
        Dictionary<char, int> chars = new Dictionary<char, int>();

        foreach (char c in loweredWord)
        {
            if (chars.ContainsKey(c))
            {
                chars[c]++;
            }
            else
            {
                chars[c] = 1;
            }
        }

        char returnedChar = ' ';
        int valueChar = 0;

        foreach (KeyValuePair<char, int> dict in chars)
        {
            if (dict.Value > valueChar)
            {
                returnedChar = dict.Key;
                valueChar = dict.Value;
            }
        }

        return returnedChar;
    }
}