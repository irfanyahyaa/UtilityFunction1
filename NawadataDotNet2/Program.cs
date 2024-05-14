using System.Security.Cryptography.X509Certificates;
using NawadataDotNet2;

public class Program
{
    public static void Main(string[] args)
    {
        // number 1
        string number1 = "Halo, nama saya John Doe";

        WordCounter wc = new WordCounter();

        Console.WriteLine("===============");
        Console.WriteLine("Number 1:");
        Console.WriteLine($"\"{number1}\" consists of: {wc.WordCounterFunc(number1)} words");

        // number 2
        int[] number2 = new[] { 1, 5, 3, 7, 2 };

        MaxValue mv = new MaxValue();

        Console.WriteLine("===============");
        Console.WriteLine("Number 2:");
        Console.WriteLine($"Maximum value of given array is: {mv.MaxValueFunc(number2)}");

        // number 3
        int[] number3 = new[] { 3, 1, 5, 2, 4 };

        SortNumber sn = new SortNumber();

        Console.WriteLine("===============");
        Console.WriteLine("Number 3:");
        Console.Write("Sorted array of given array is: ");
        sn.PrintArray(number3);
        Console.WriteLine();

        // number 4
        string number4 = "hello";

        MostAppearChar mac = new MostAppearChar(); 
        
        Console.WriteLine("===============");
        Console.WriteLine("Number 4:");
        Console.Write($"Most appear char of given word is: {mac.MostAppearCharFunc(number4)}");
    }
}