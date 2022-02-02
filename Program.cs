using System;
namespace SelfWriter
{
    class Program
    {
        public static void Main(string[] args)
        {
            const int delay = 1;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            

            var curDir = Directory.GetCurrentDirectory();
            var curFilePath = Directory.GetParent(curDir)?.Parent?.Parent?.GetFiles("*.cs")[0].FullName;

            var allCodeLines = File.ReadAllLines(curFilePath);

            foreach (var line in allCodeLines)
            {
                foreach (var word in line.Split())
                {
                    Console.Write(word + " ");
                    Thread.Sleep(delay);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}