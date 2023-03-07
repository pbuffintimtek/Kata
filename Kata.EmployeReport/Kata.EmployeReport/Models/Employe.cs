using System;

namespace Kata.EmployeReport.Models
{
    public record Employe
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Employe(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static Employe Create(string name, int age)
        {
            return new Employe(name, age);
        }
    }
}