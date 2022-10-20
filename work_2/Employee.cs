using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    public class Employee
    {
        public int Id { get; set; } 

        public string FirstName { get; set; }
        public string LastName { get; set; }

       
        public Employee()
        {

        }
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName}";
        }

    }
}
