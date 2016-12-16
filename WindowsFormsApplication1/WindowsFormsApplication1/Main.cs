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
    public partial class Main : Form
    {

        List<Employee2> employees;
        List<Employee2> sorted;
        Boolean isSorted;
        Stopwatch stopwatch;
        public Main()
        {
            InitializeComponent();
            employees = new List<Employee2>();
            isSorted = false;
            stopwatch = new Stopwatch();

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Employee2 emp;
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < 6000; i++)
            {
                emp = new Employee2();
                employees.Add(emp);

            }
            stopwatch.Stop();
            employees_to_grid(employees);
            
            timer_lb.Text = "time to create employees list: " + stopwatch.Elapsed.ToString();
        }

        private void employees_to_grid(List<Employee2> employees)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < employees.Count; i++)
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

        public void sort_bubble_bt_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            sorted = myBubbleSort(employees);
            stopwatch.Stop();

            employees_to_grid(sorted);
            timer_lb.Text = "time to sort all employees USING BUBBLE SORT O(N*N): " + stopwatch.Elapsed.ToString();
        }
        public List<Employee2> myBubbleSort(List<Employee2> unsortedEmployees)
        {
            if (unsortedEmployees.Count > 1)
                bubbleSortList(unsortedEmployees);
            return unsortedEmployees;
        }
        /* bubble sort v1:
         * 
         * leave the list untouched
         * 
        public List<Employee2> myBubbleSort(List<Employee2> unsortedEmployees)
        {
            return unsortedEmployees;
        }
        */
        private static void bubbleSortList(List<Employee2> unsortedEmployees)
        {
            int unsortedLength = unsortedEmployees.Count;
            for (int i = unsortedLength - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (unsortedEmployees.ElementAt(j).salary >
                            unsortedEmployees.ElementAt(j + 1).salary)
                        SwapElements(unsortedEmployees, j);
                }
            }
        }
        private static void SwapElements(List<Employee2> unsortedEmployees, int j)
        {
            Employee2 e = unsortedEmployees.ElementAt(j);
            unsortedEmployees.RemoveAt(j);
            unsortedEmployees.Insert(j+1, e);
        }
        /* swap elements v1:
        * 
        * previous version error:
        * after removal, insertion was at index j and not index j+1
        * result was having the exact same list even after "swap"
        * 
        private static void SwapElements(List<Employee2> unsortedEmployees, int j)
        {
            Employee2 e = unsortedEmployees.ElementAt(j);
            unsortedEmployees.RemoveAt(j);
            unsortedEmployees.Insert(j, e);
        }
        */

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            sorted = myMergeSort(employees);
            stopwatch.Stop();

            employees_to_grid(sorted);
            timer_lb.Text = "time to sort all employees USING Merge SORT O(N*log(N)): " + stopwatch.Elapsed.ToString();
        }

        private List<Employee2> myMergeSort(List<Employee2> unsortedEmployees)
        {
            return unsortedEmployees;
        }
        


    }
}
