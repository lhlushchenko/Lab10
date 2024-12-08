namespace Task4;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Колекція доменних імен сайтів
        List<string> websites = new List<string>
        {
            "https://example.com",
            "https://mysite.ru",
            "https://another-site.org",
            "https://website.ua",
            "https://sample.net",
            "https://msdn.microsoft.com",
            "https://tech.ru",
            "https://blogspot.com",
            "https://portal.msdn",
            "https://news.ru"
        };

        // Запит LINQ для відбору сайтів з доменами ".ru" та ".msdn"
        var filteredWebsites = websites.Where(site => site.EndsWith(".ru", StringComparison.OrdinalIgnoreCase) || site.Contains("msdn", StringComparison.OrdinalIgnoreCase));

        // Вивід результатів
        Console.WriteLine("Сайти, які відповідають критеріям:");
        foreach (var site in filteredWebsites)
        {
            Console.WriteLine(site);
        }
    }
}