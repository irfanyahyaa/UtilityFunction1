namespace NawadataDotNet2;

public class MaxValue
{
    public int MaxValueFunc(int[] arrOfInt)
    {
        int max = arrOfInt[0];
        for (var i = 1; i < arrOfInt.Length; i++)
        {
            if (arrOfInt[i] > max)
            {
                max = arrOfInt[i];
            }
        }

        return max;
    }
}