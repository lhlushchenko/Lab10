namespace Task3;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Клас Model
    class Model
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }

    static void Main()
    {
        // Колекція моделей
        List<Model> models = new List<Model>
        {
            new Model { Name = "Anna", LastName = "Smith", Age = 23, Height = 178, Weight = 50 },
            new Model { Name = "Maria", LastName = "Johnson", Age = 26, Height = 180, Weight = 54 },
            new Model { Name = "Kate", LastName = "Williams", Age = 22, Height = 175, Weight = 55 },
            new Model { Name = "Olga", LastName = "Brown", Age = 25, Height = 179, Weight = 52 },
            new Model { Name = "Elena", LastName = "Jones", Age = 24, Height = 176, Weight = 53 },
            new Model { Name = "Sophie", LastName = "Garcia", Age = 21, Height = 172, Weight = 56 },
            new Model { Name = "Natalie", LastName = "Martinez", Age = 22, Height = 177, Weight = 54 },
            new Model { Name = "Victoria", LastName = "Hernandez", Age = 20, Height = 175, Weight = 49 },
            new Model { Name = "Emma", LastName = "Lopez", Age = 27, Height = 174, Weight = 57 },
            new Model { Name = "Sophia", LastName = "Gonzalez", Age = 19, Height = 178, Weight = 51 }
        };

        // Запит LINQ для відбору моделей до агентства
        var filteredModels = models
            .Where(m => m.Age <= 25 && m.Height >= 175 && m.Height <= 180 && m.Weight <= 55)
            .OrderBy(m => m.LastName)
            .ToList();

        // Модель з найменшою вагою
        var lightestModel = filteredModels.OrderBy(m => m.Weight).FirstOrDefault();

        // Вивід результатів
        Console.WriteLine("Моделі, які підходять до агентства:");
        foreach (var model in filteredModels)
        {
            Console.WriteLine($"{model.LastName}, {model.Name}: Age={model.Age}, Height={model.Height}, Weight={model.Weight}");
        }

        if (lightestModel != null)
        {
            Console.WriteLine("\nМодель з найменшою вагою:");
            Console.WriteLine($"{lightestModel.LastName}, {lightestModel.Name}: Age={lightestModel.Age}, Height={lightestModel.Height}, Weight={lightestModel.Weight}");
        }
    }
}
