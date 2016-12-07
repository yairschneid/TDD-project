using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Employee
    {
        public int ID;
        public string firstName;
        public string lastName;
        public int salary;

        public Employee(int ID, string firstName, string lastName, int salary)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        
    }
}
