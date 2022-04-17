using System;
using System.IO;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var sw = File.AppendText("startup.txt");
            var time = DateTime.Now.ToString("HH:mm:ss tt");
            sw.WriteLine(time);
            Console.WriteLine($"{time}");
        }
    }
}
