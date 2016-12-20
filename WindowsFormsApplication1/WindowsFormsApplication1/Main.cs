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
        Stopwatch stopwatch;
        Boolean isSorted;

        const int EMPLOYEE_NUMBER = 10000;

        public Main()
        {
            InitializeComponent();
            employees = new List<Employee2>();
            stopwatch = new Stopwatch();
            isSorted = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Employee2 emp;
            if (employees.Count != 0)
            {
                employees.Clear();
                MessageBox.Show("cleared employees");
            }
            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < EMPLOYEE_NUMBER; i++)
            {
                emp = new Employee2();
                employees.Add(emp);

            }
            stopwatch.Stop();
            isSorted = false;
            employees_to_grid(employees);
            
            timer_lb.Text = "time to create employees list: " + stopwatch.Elapsed.TotalMilliseconds + " ms";
        }

        public void sort_bubble_bt_Click(object sender, EventArgs e)
        {
            if (isSorted)
            {
                MessageBox.Show("List already sorted.\n" + "consider creating new list, or reverting to the unsorted one.");
                return;
            }
            if (employees.Count == 0)
            {
                MessageBox.Show("please fill employee table first");
                return;
            }
            stopwatch.Reset();
            stopwatch.Start();
            sorted = myBubbleSort(new List<Employee2>(employees));
            isSorted = true;
            stopwatch.Stop();

            employees_to_grid(sorted);
            timer_lb.Text = "time to create employees list: " + stopwatch.Elapsed.TotalMilliseconds + " ms";
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
            Employee2 e = unsortedEmployees[j];
            unsortedEmployees[j] = unsortedEmployees[j + 1];
            unsortedEmployees[j + 1] = e;
        }
        /* swap elemnts v2:
         * 
         *  error was using "remove at" and "insert" which were expensive O(n) actions
         * 
         * 
        private static void SwapElements(List<Employee2> unsortedEmployees, int j)
        {
            Employee2 e = unsortedEmployees.ElementAt(j);
            unsortedEmployees.RemoveAt(j);
            unsortedEmployees.Insert(j+1, e);
        }
        *
        */
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
            if (isSorted)
            {
                MessageBox.Show("List already sorted.\n" + "consider creating new list, or reverting to the unsorted one.");
                return;
            }
            if (employees.Count == 0)
            {
                MessageBox.Show("please fill employee table first");
                return;
            }
            stopwatch.Reset();
            stopwatch.Start();
            sorted = myMergeSort(new List<Employee2>(employees) );
            isSorted = true;
            stopwatch.Stop();

            employees_to_grid(sorted);
            timer_lb.Text = "time to create employees list: " + stopwatch.Elapsed.TotalMilliseconds + " ms";
        }
        public List<Employee2> myMergeSort(List<Employee2> unsortedEmployees)
        {
            if (unsortedEmployees.Count > 1)
                mergeSortList(unsortedEmployees, 0, unsortedEmployees.Count - 1);

            return unsortedEmployees;
        }
        /* myMergeSort v1
         * 
         * error: the amount used was the constant "employee number" (100"
         *          instead of list length, which was 5 at time of test
         * 
        public List<Employee2> myMergeSort(List<Employee2> unsortedEmployees)
        {
            if (unsortedEmployees.Count > 1)
                mergeSortList(unsortedEmployees, 0, EMPLOYEE_NUMBER - 1);
            return unsortedEmployees;
        }

        */
        private void mergeSortList(List<Employee2> unsortedEmployees, int leftIndex, int rightIndex)
        {
            int mid;
            if (rightIndex > leftIndex)
            {
                mid = (rightIndex + leftIndex) / 2;

                mergeSortList(unsortedEmployees, leftIndex, mid);
                mergeSortList(unsortedEmployees, (mid + 1), rightIndex);

                mergeSubLists(unsortedEmployees, leftIndex, (mid + 1), rightIndex);
            }
        }
        private void mergeSubLists(List<Employee2> unsortedEmployees, int leftIndex, int middleIndex, int rightIndex)
        {
            List<Employee2> temp = new List<Employee2>();
            int left_end, num_elements, originalLeft = leftIndex, originalRight = rightIndex;

            left_end = middleIndex - 1;
            num_elements = rightIndex - leftIndex + 1;
            
            // merge left part and right part, until reach either part's end
            while ((leftIndex <= left_end) && (middleIndex <= rightIndex))
            {
                if (unsortedEmployees[leftIndex].salary <= unsortedEmployees[middleIndex].salary)
                    temp.Add(unsortedEmployees[leftIndex++]);
                else
                    temp.Add(unsortedEmployees[middleIndex++]);
            }

            // reached end of right part first, fill rest of left part
            while (leftIndex <= left_end)
            {
                temp.Add(unsortedEmployees[leftIndex++]);
            }

            // reached end of left part first, fill rest of right part
            while (middleIndex <= rightIndex)
            {
                temp.Add(unsortedEmployees[middleIndex++]);
            }

            //copy back merged into fitting place in list
            int j = 0;
            for (int i = originalLeft; i<= originalRight; i++)
            {
                unsortedEmployees[i] = temp[j];
                j++;
            }


        }
        /* mergeSubLists v1
         *  
         * 
         *  error: index problems, when copying temp array back to unsortedEmployees
         * 
        private void mergeSubLists(List<Employee2> unsortedEmployees, int leftIndex, int middleIndex, int rightIndex)
        {
            List<Employee2> temp = new List<Employee2>();
            int i, left_end, num_elements;

            left_end = (middleIndex - 1);
            num_elements = (rightIndex - leftIndex + 1);

            while ((leftIndex <= left_end) && (middleIndex <= rightIndex))
            {
                if (unsortedEmployees.ElementAt(leftIndex).salary
                        <= unsortedEmployees.ElementAt(middleIndex).salary)
                    temp.Add(unsortedEmployees.ElementAt(leftIndex++));
                else
                    temp.Add(unsortedEmployees.ElementAt(middleIndex++));
            }

            while (leftIndex <= left_end)
                temp.Add(unsortedEmployees.ElementAt(leftIndex++));

            while (middleIndex <= rightIndex)
                temp.Add(unsortedEmployees.ElementAt(middleIndex++));

            for (i = 0; i < num_elements; i++)
            {
                unsortedEmployees[rightIndex] = temp.ElementAt(rightIndex);
                rightIndex--;
            }
        }
        */
        /*  merge sort v2
         * 
         * Error: using the array [] notation with the manual handling of position marker 
         *          "temp pos" caused out of bound error (due to C# list implementation
         * 
        private void mergeSubLists(List<Employee2> unsortedEmployees, int leftIndex, int middleIndex, int rightIndex)
        {
            List<Employee2> temp = new List<Employee2>();
            int i, left_end, num_elements, tmp_pos;

            left_end = (middleIndex - 1);
            tmp_pos = leftIndex;
            num_elements = (rightIndex - leftIndex + 1);

            while ((leftIndex <= left_end) && (middleIndex <= rightIndex))
            {
                if (unsortedEmployees.ElementAt(leftIndex).salary
                        <= unsortedEmployees.ElementAt(middleIndex).salary)
                    
                    
                else
                    temp[tmp_pos++] = unsortedEmployees.ElementAt(middleIndex++);
                    
            }

            while (leftIndex <= left_end)
                temp[tmp_pos++] = unsortedEmployees.ElementAt(leftIndex++);
                

            while (middleIndex <= rightIndex)
                temp[tmp_pos++] = unsortedEmployees.ElementAt(middleIndex++);
                
            for (i = 0; i < num_elements; i++)
            {
                unsortedEmployees[rightIndex] = temp.ElementAt(rightIndex);
                rightIndex--;
            }
        }
        *
        */
        /* merge sort v1:
        * 
        * leave the list untouched
        * 
        public List<Employee2> myMergeSort(List<Employee2> unsortedEmployees)
        {
            return unsortedEmployees;
        }
        */

        private void revert_bt_Click(object sender, EventArgs e)
        {
            if (employees.Count == 0)
            {
                MessageBox.Show("please create employees database first");
                return;
            }
            employees_to_grid(employees);
            isSorted = false;
        }
        
    }
}
