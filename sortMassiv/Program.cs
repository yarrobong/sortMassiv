using System;

class Program
{
    static void Main()
    {
        int[] A = { 5, 8, 3, 12, 7, 10, 4, 6, 2, 9 };

        int min = A[0], max = A[0];
        int minIndex = 0, maxIndex = 0;
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] < min)
            {
                min = A[i];
                minIndex = i;
            }
            if (A[i] > max)
            {
                max = A[i];
                maxIndex = i;
            }
        }

        int start = Math.Min(minIndex, maxIndex) + 1;
        int end = Math.Max(minIndex, maxIndex) - 1;

        double average = 0.0;
        int sum = 0;
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            sum += A[i];
            count++;
        }

        if (count > 0)
        {
            average = (double)sum / count;
        }
        else
        {
            Console.WriteLine("Не найдены элементы между минимальным и максимальным.");
        }

        Array.Sort(A);
        Array.Reverse(A);

        Console.WriteLine($"Среднее арифметическое элементов: {average}");
        Console.WriteLine("Отсортированный массив по убыванию:");
        foreach (int element in A)
        {
            Console.Write(element + " ");
        }
    }
}