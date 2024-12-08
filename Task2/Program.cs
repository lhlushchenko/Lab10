namespace Task2;

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив тексту
        string[] textArray = {
            "ПІ-91 це найкраща група!",
            "ПІ-91 має гарні показники.",
            "Інші групи не такі як ПІ-91.",
            "ПІ-91 завжди попереду!"
        };

        // Використання LINQ для підрахунку повторень слова "ПІ-91"
        int count = textArray.Sum(line => line.Split(new[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
            .Count(word => word.Equals("ПІ-91", StringComparison.OrdinalIgnoreCase)));

        // Вивід результатів
        Console.WriteLine($"Кількість повторень слова 'ПІ-91': {count}");
    }
}