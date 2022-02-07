
        static string HighAndLow(string numbers)
        {
            string[] char_arr = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numlist = new List<int>();

            foreach (string ch in char_arr)
            {
                numlist.Add(int.Parse(ch));
                Console.WriteLine(ch);
            }

            int min = numlist[0], max = numlist[0];

            for (int i = 0; i < numlist.Count; i++)
            {
                if (numlist[i] > max)
                {
                    max = numlist[i];
                }
                if (numlist[i] < min)
                {
                    min = numlist[i];
                }
            }
            return $"{max} {min}";
        }
   
string num = "8 3 -5 42 -1 0 0 -9 4 7 4 -1";
Console.WriteLine(HighAndLow(num));

