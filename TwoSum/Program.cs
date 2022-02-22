static int[] TwoSum(int[] numbers, int target)
{
    List<int> result = new List<int>();
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int a = 0; a < numbers.Length; a++)
        {
            if(numbers[i] + numbers[a] == target && i != a)
            {
                result.Add(i);
                result.Add(a);
                return result.ToArray();
            }
        }
    }
    return null;
}

int[] param = new int[] { 5, 2, 3, 5};

foreach (var item in TwoSum(param, 10))
{
    Console.WriteLine(item);
}