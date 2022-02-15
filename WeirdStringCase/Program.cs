

string ToWeirdCase(string s)
{
    List<string> words = new List<string>(s.Split(' '));
    string res = "";

    for (int i = 0; i < words.Count; i++)
    {
        words[i] = words[i].ToLower();
    }

    foreach (string item in words)
    {
        if (item != words[0])
        {
            res += " ";
        }
        for (int i = 0; i < item.Length; i++)
        {
            if (i % 2 == 0)
            {
                res += item[i].ToString().ToUpper();
            }
            else
            {
                res += item[i];
            }
        }
    }
    
    //res = res.Trim(' ');
    return res;
}

Console.Write(ToWeirdCase("Weird string case"));
