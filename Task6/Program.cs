namespace Task6;

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

        // Вибір 3 чисел, починаючи з другого
        var selectedNumbers = numbers.Skip(1).Take(3);

        // Вивід результату
        Console.WriteLine("Середнє арифметичне чисел:");
        Console.WriteLine(average);

        Console.WriteLine("Вибрані числа:");
        foreach (var number in selectedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}