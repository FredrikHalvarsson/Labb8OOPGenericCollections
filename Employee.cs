using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8OOPGenericCollections
{
    internal class Employee
    {
        //Här finns inget nytt att förklara som inte har förklarats i tidigare labbar. en enkel klass med konstruktor, egenskaper och en metod.
        public Employee(int id, string name, string gender, int salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public void Display()
        {
            Console.WriteLine("-----------------------Employee info-----------------------");
            Console.WriteLine($"ID: {ID}\nName: {Name}\nGender: {Gender}\nSalary: {Salary}");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
