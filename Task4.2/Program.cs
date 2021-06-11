using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4._2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("URL = ");
            var url = Console.ReadLine();
            using var client = new HttpClient();
            var content = await client.GetStringAsync("https://"+url);

            var regex = new Regex(@"href='(?<link>\S+)'>");

            foreach (Match m in regex.Matches(content))
            {
                Console.WriteLine("ССЫЛКА: {0,-25}", m.Groups["link"]);
            }
            regex = new Regex(@"(?<phone>[+3(0-90-90-9)\s]{2,}[0-9]{3}[\s\-][0-9]{2}[\s\-][0-9]{2})");

            foreach (Match m in regex.Matches(content))
            {
                Console.WriteLine("Тел. номер: {0,-25}", m.Groups["phone"]);
            }

            regex = new Regex(@"(?<email>[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4})");

            foreach (Match m in regex.Matches(content))
            {
                Console.WriteLine("E-Mail: {0,-25}", m.Groups["email"]);
            }
        }
    }
}
