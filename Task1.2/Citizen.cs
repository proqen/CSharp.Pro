using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._3
{
    abstract class Citizen
    {
        [Key]
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }

        public override string ToString()
        {
            return Id + " " + FullName + " " + DOB.ToString();
        }
        public static bool operator ==(Citizen a, Citizen b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }
            return a.Id == b.Id;
        }
        public static bool operator !=(Citizen a, Citizen b)
        {
            return !(a == b);
        }
    }
    class Student : Citizen
    {
        public Student(string Id, string FullName, DateTime DOB) : base() =>
        (this.Id, this.FullName, this.DOB) = (Id, FullName, DOB);
    }
    class Worker : Citizen
    {
        public Worker(string Id, string FullName, DateTime DOB) : base() =>
        (this.Id, this.FullName, this.DOB) = (Id, FullName, DOB);
    }
    class Pensioner : Citizen
    {
        public Pensioner(string Id, string FullName, DateTime DOB) : base() =>
        (this.Id, this.FullName, this.DOB) = (Id, FullName, DOB);
    }
}
