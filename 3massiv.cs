using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 10, 5, 7, 14, 3 };
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = (double)sum / numbers.Length;
        Console.WriteLine("Сумма элементов массива: " + sum);
        Console.WriteLine("Среднее арифметическое элементов массива: " + average);
    }
}


