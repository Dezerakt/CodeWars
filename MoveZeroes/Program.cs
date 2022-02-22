static int[] MoveZeroes(int[] arr)
{
    List<int> new_arr = new List<int>();
    int nulls = 0;
    foreach(int i in arr)
    {
        if(i != 0)
        {
            new_arr.Add(i);
        }
        else
        {
            nulls++;
        }
    }
    for (int i = 0; i < nulls; i++)
    {
        new_arr.Add(0);
    }


    return new_arr.ToArray();
}

int[] arr = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
foreach (int item in MoveZeroes(arr))
{
    Console.WriteLine(item);
}