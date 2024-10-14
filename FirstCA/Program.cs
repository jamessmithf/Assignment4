using System;
using System.Text.Json;

namespace FirstCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var riversJson = File.ReadAllText("C:\\Users\\vikto\\source\\repos\\Assignment4\\json files\\rivers.json");
            var mountainsJson = File.ReadAllText("C:\\Users\\vikto\\source\\repos\\Assignment4\\json files\\mountains.json");
            List<River> rivers = JsonSerializer.Deserialize<List<River>>(riversJson);
            List<Mountain> mountains = JsonSerializer.Deserialize<List<Mountain>>(mountainsJson);

            for (int i = 0; i < rivers.Count; i += 2)
            {
                rivers[i].GetInfo();
                Console.WriteLine();
            }

            for (int i = 1; i < mountains.Count; i += 2)
            {
                mountains[i].GetInfo();
                Console.WriteLine();
            }
        }
    }
}
