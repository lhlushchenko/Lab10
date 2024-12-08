namespace Task5;

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив чисел
        int[] numbers = { 2, 12, 14, 18, 25, 15 };

        // Обчислення середнього арифметичного
        double average = numbers.Average();

        // Вивід результату
        Console.WriteLine("Середнє арифметичне чисел:");
        Console.WriteLine(average);
    }
}
