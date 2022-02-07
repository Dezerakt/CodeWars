static List<string> Anagrams(string word, List<string> words)
{
    List<char> origin = new List<char>(word.ToList());
    List<string> res = new List<string>();
    foreach (string c in words)
    {
        List<char> temp_list = new List<char>(c.ToList());
        foreach (char ch in origin)
        {
            if (temp_list.Contains(ch))
            {
                temp_list.Remove(ch);
            }
        }
        if(temp_list.Count == 0)
        {
            res.Add(c);
        }
        temp_list.Clear();
    }
    

    return res;
}

string word = "racer";

List<string> words = new List<string>() { "crazer", "carer", "racar", "caers", "racer" };

foreach(string c in Anagrams(word, words))
{
    Console.WriteLine(c + "\n");
}