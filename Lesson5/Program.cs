using System;
using System.IO;


namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольные данные");
           string text = Console.ReadLine();
            string filename = "text.txt";
            File.WriteAllText(filename, text);
            Console.ReadLine();
           
        }
    }
}
