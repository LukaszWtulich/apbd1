using System;

public class Project1
{
    public static void Main(string[] args)
    {
        int[] numbers = { 10, 5, 20, 15, 30 };
        int max = FindMax(numbers);
        Console.WriteLine("Maksymalna wartość w tablicy: " + max);
    }

    public static int FindMax(int[] array)
    {

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}