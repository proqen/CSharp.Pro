using System;
using System.Collections.Generic;

namespace Task1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            CitizenCollection citizens = new CitizenCollection();

            var s1 = new Student("s1","Kamchybek",DateTime.Now);
            var s2 = new Student("s2","Kamchybek",DateTime.Now);
            var s3 = new Student("s3","Kamchybek",DateTime.Now);

            var p1 = new Pensioner("p1","Kamchybek",DateTime.Now);
            var p2 = new Pensioner("p2","Kamchybek",DateTime.Now);

            citizens.Add(s1);
            citizens.Add(s2);
            citizens.Add(s3);

            citizens.Add(p1);
            citizens.Add(p2);

            foreach (Citizen item in citizens)
                Console.WriteLine(item.ToString());

            //Console.WriteLine(citizens.Count);
            Console.WriteLine("-------");
            //Console.WriteLine(p2);
            citizens.Remove(); 
            citizens.Remove(); 
            citizens.Remove(); 
            citizens.Remove(); 
            citizens.Remove(); 
            citizens.Remove(); 
            Console.WriteLine("-------");


            foreach (Citizen item in citizens)
                Console.WriteLine(item.ToString());
        }
    }
}
