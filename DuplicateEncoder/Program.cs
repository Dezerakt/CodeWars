static string DuplicateEncode(string word)
{
    word = word.ToLower();
    Dictionary<char, int> char_dict = new Dictionary<char, int>();
    string res = string.Empty;

    foreach (char item in word)
    {
        if (char_dict.ContainsKey(item))
        {
            char_dict[item] = char_dict[item] + 1;
        }
        else
        {
            char_dict.Add(item, 1);
        }
    }

    foreach (var item in word)
    {
        if (char_dict[item] == 1)
        {
            res += "(";
        }
        else if (char_dict[item] > 1)
        {
            res += ")";
        }
    }

    
    return res;
}

string str = "DoneD";
Console.WriteLine(DuplicateEncode(str));