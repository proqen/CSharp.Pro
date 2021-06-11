using System;

namespace Task7._2
{
    class MyClass
    {
        [Obsolete("Метод устарел")]
        public void WarningMessage()
        {
            Console.WriteLine("Hello world!, WarningMessage");
        }
        [Obsolete("Метод не используеться", true)]
        public void ErrorMessage()
        {
            Console.WriteLine("Hello world!, ErrorMessage");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new();
            myClass.WarningMessage();

            //myClass.ErrorMessage();
        }
    }
}
