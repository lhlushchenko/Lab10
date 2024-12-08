namespace Task1;

using System.Linq;

class Program
{
    static void Main()
    {
        // Масив адрес сайтів
        string[] websites = {
            "https://example.com",
            "https://mysite.ua",
            "https://another-site.org",
            "https://website.ua",
            "https://sample.net",
            "https://ukrainian-portal.ua"
        };

        // Використання LINQ для відбору адрес з доменом .ua
        var ukrainianSites = websites.Where(site => site.EndsWith(".ua", StringComparison.OrdinalIgnoreCase));

        // Вивід результатів
        Console.WriteLine("Сайти з доменом .ua:");
        foreach (var site in ukrainianSites)
        {
            Console.WriteLine(site);
        }
    }
}