namespace NawadataDotNet2;

public class SortNumber
{
    public int[] SortNumberFunc(int[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            for (var j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }

        return arr;
    }

    public void PrintArray(int[] arr)
    {
        int[] sortedArr = SortNumberFunc(arr);

        for (var i = 0; i < sortedArr.Length; i++)
        {
            Console.Write($"{sortedArr[i]}, ");
        }
    }
}