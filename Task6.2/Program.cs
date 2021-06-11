using System;
using System.Reflection;

namespace Task6._2
{
    public interface ITemperature
    {
        double Fahrenheit(double celsius);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.Load("Task6.2.Library");

            dynamic obj = Activator.CreateInstance(asm.GetType("Task6._2.Library.Temperature"));

            Console.WriteLine("15 °C по °F равно " + obj.Fahrenheit(15d));
        }
    }
}
