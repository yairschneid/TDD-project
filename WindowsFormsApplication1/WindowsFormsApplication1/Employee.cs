using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Employee : Form1
    {
        public int ID;
        public string firstName;
        public string lastName;
        public int salary;
        public string[] firstNames = { "Sali", "yoad", "yair", "Itamar", "Alex", "Benjamin", "Shimon", "Sarah", "yosef", "Pedut", "Yulia", "Tehila" };
        public string[] lastNames = { "Ben Mocha", "Wolfstall", "Schneid", "Avrahami", "Shmukler", "Benjamin", "Raviv", "Burman", "yosef", "Shukrun", "Zorin", "Bitarov" };

        public Employee(int ID, string firstName, string lastName, int salary)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public Employee()
        {
        }

        public void CreateEmployeeList()
        {
           for (int i = 0; i < 10000; i++)
            {
                Employee emp = new Employee(randomID(), randomFirst(), randomLast(), randomSalary());
                //DataGridViewRow row = (DataGridViewRow)dgv.Rows[i].Clone();
                //row.Cells[0].Value = emp.ID;
                //row.Cells[1].Value = emp.firstName;
                //row.Cells[2].Value = emp.lastName;
                //row.Cells[3].Value = emp.salary;
                //dgv.Rows.Add(row);
            }

        }

        public int randomID()
        {
            Random rnd = new Random();
            return rnd.Next(100000000, 999999999);
        }

        public int randomSalary()
        {
            Random rnd = new Random();
            return rnd.Next(5000, 30000);
        }

        public string randomFirst()
        {
            Random rnd = new Random();
            return firstNames[rnd.Next(0, 12)];
        }

        public string randomLast()
        {
            Random rnd = new Random();
            return lastNames[rnd.Next(0, 12)];
        }
    }
}
