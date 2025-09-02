using System.Text;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
        Console.WriteLine(WordPattern("abba", "dog cat cat fish"));
    }
    public static bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');
        if (pattern.Length != words.Length)
            return false;
        Dictionary<char,string> charToString = new Dictionary<char,string>();
       // Dictionary<string,char> stringToChar= new Dictionary<string,char>();
        for (int i = 0; i < pattern.Length; i++)
        {
            char c = pattern[i];
            string word=words[i];
            if(charToString.ContainsKey(c))
            {
                if (charToString[c] != word)
                {
                    return false;
                }
            }
            else
            {
                if(charToString.ContainsValue(word))
                {
                    return false ;
                }
                charToString[c] = word;
            }
            //char c = pattern[i];
            //string word=words[i];
            //if (charToString.ContainsKey(c))
            //{
            //    if (charToString[c] != word)
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    charToString[c]= word;
            //}
            //if (stringToChar.ContainsKey(word))
            //{
            //    if (stringToChar[word] != c)
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    stringToChar[word]= c; 
            //}
        }
        return true;

    }
}