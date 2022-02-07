static int Solution(string roman)
{
	int res = 0;
	List<char> vs = new List<char>(roman.ToList());

	Dictionary<char, int> map = new Dictionary<char, int>()
	{
		{'I', 1},
		{'V', 5},
		{'X', 10},
		{'L', 50},
		{'C', 100},
		{'D', 500},
		{'M', 1000},
	};


    for (int i = 0; i < vs.Count; i++)
    {
        try
        {
			res += map[vs[i]];
		}
		catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("end of list");
        }
    }

    return res;
}

string num = "MMM";

Console.WriteLine(Solution(num));

//Не закончил