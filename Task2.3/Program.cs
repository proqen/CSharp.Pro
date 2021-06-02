using System;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            BalanceCollection collection = new BalanceCollection();

            collection.Add(1,1.0);
            collection.Add(2,2.0);
            collection.Add(3,3.0);

            foreach (var item in collection)
            {
                Console.WriteLine(item.Account + " " + item.Amount);
            }
        }
    }
}
