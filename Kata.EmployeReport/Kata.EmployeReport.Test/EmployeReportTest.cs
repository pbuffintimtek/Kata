using Kata.EmployeReport.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.EmployeReport.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldGetListOfEmployeesAllowToWorkOnSunday()
        {
            var employeesAllowToWorkOnSunday = EmployeRegistery.Create().GetEmployeesAllowToWorkOnSunday();

            Assert.That(employeesAllowToWorkOnSunday, Is.EqualTo(new List<Employe>()
            {
                Employe.Create("Sepp", 18),
                Employe.Create("Mike", 51)
            }));
        }

        [Test]
        public void ShouldGetListOfEmployeesOderByName()
        {
            var employeesAllowToWorkOnSunday = EmployeRegistery.Create().OrderEmployeesByName();

            Assert.That(employeesAllowToWorkOnSunday, Is.EqualTo(new List<Employe>()
            {
                Employe.Create("Max", 17),
                Employe.Create("Mike", 51),
                Employe.Create("Mina", 15),
                Employe.Create("Sepp", 18)
            }));
        }
        
        [Test]
        public void ShouldGetListOfEmployeesWithNameCapitalize()
        {
            var employeesAllowToWorkOnSunday = EmployeRegistery.Create().CapitalizeName();

            Assert.That(employeesAllowToWorkOnSunday, Is.EqualTo(new List<Employe>()
            {
                Employe.Create("MAX", 17),
                Employe.Create("SEPP", 18),
                Employe.Create("MINA", 15),
                Employe.Create("MIKE", 51)                   
            }));
        } 
        
        [Test]
        public void ShouldGetListOfEmployeesOderByNameDescending()
        {
            var employeesAllowToWorkOnSunday = EmployeRegistery.Create().OrderEmployeesByName(OrderDirection.Descending);

            Assert.That(employeesAllowToWorkOnSunday, Is.EqualTo(new List<Employe>()
            {
               Employe.Create("Sepp", 18),
               Employe.Create("Mina", 15),
               Employe.Create("Mike", 51),
               Employe.Create("Max", 17) 
            }));
        }
    }
}