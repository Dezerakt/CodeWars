
namespace CodeWarsProject
{
    internal class FindEvenIndexClass
    {
        static int FindEvenIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int left_side = 0, right_side = 0;

                for (int r = i + 1; r < arr.Length; r++)
                {
                    right_side += arr[r];
                }

                for (int l = 0; l < i; l++)
                {
                    left_side += arr[l];
                }

                if (left_side == right_side)
                {
                    return left_side;
                }
            }

            return -1;
        }


    }
}
