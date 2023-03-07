using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.EmployeReport.Models
{
    public class EmployeRegistery
    {
        private const int AgeMinimumToWorkOnSunday = 18;
        public ICollection<Employe> Employes { get; set; }
        public EmployeRegistery()
        {
            Employes = new List<Employe>
            {
                Employe.Create("Max", 17),
                Employe.Create("Sepp", 18),
                Employe.Create("Mina", 15),
                Employe.Create("Mike", 51)
            };
        }

        public static EmployeRegistery Create()
        {
            return new EmployeRegistery();
        }

        public List<Employe> GetEmployeesAllowToWorkOnSunday()
        {
            return Employes.Where(x => x.Age >= AgeMinimumToWorkOnSunday).ToList();
        }

        public List<Employe> OrderEmployeesByName(OrderDirection direction = OrderDirection.Ascending)
        {
            if (direction == OrderDirection.Ascending)
                return Employes.OrderBy(x => x.Name).ToList();
            else
                return Employes.OrderByDescending(x => x.Name).ToList();
        }

        public List<Employe> CapitalizeName()
        {
            return Employes.Select(x => new Employe(x.Name.ToUpperInvariant(), x.Age)).ToList();
        }
    }
}
