using System;

public class Project1
{
    public static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia wartość w tablicy: " + average);
    }

    public static double CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}