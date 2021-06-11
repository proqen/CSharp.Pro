using System;
using System.IO;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = File.CreateText("test.txt");
            writer.WriteLine("Hello world");
            writer.Close();

            StreamReader reader = File.OpenText("test.txt");
            string text = reader.ReadToEnd();
            Console.WriteLine(text);

        }
    }
}
