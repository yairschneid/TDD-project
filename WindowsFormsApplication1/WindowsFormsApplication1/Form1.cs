using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        List<Employee2> employees;
        Boolean sorted;
        Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee2>();
            sorted = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Employee emp = new Employee();
            //emp.CreateEmployeeList();
            Employee2 emp;
            stopwatch= new Stopwatch();
            stopwatch.Start();
            
            for (int i = 0; i < 10000; i++)
            {
                emp = new Employee2();
                employees.Add(emp);
                
            }
            
            employees_to_grid(employees);
            stopwatch.Stop();
            timer_lb.Text = stopwatch.Elapsed.ToString();
        }

        private void employees_to_grid(List<Employee2> employees)
        {
            dataGridView1.Rows.Clear();
            for (int i =0; i< employees.Count; i++)
            {
                Employee2 emp = employees[i];
                string[] row = new string[] { emp.ID.ToString(), emp.firstName, emp.lastName, emp.salary.ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sort_bubble_bt_Click(object sender, EventArgs e)
        {
            List<Employee2> sorted = sort_list(employees);
            employees_to_grid(sorted);
        }

        private List<Employee2> sort_list(List<Employee2> employees)
        {
            employees.Reverse();
            return employees;
        }
    }
}
