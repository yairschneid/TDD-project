using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System.Collections.Generic;

namespace testing_sort
{
    [TestClass()]
    public class UnitTest1
    {
        public Main main;
        public List<Employee2> scrambled;
        public List<Employee2> sorted;
        public Employee2 em1, em2, em3, em4, em5, em6, em7, em8, em9;

        [TestInitialize()]
        public void Initialize() {
            main = new Main();
            scrambled = new List<Employee2>();
            sorted = new List<Employee2>();
            
            em1 = new Employee2(3000);
            em2 = new Employee2(4000);
            em3 = new Employee2(7890);
            em4 = new Employee2(7890);
            em5 = new Employee2(10000);
            em6 = new Employee2(12345);
            em7 = new Employee2(14000);
            em8 = new Employee2(14000);
            em9 = new Employee2(15000);

        }

        #region merge sort
        #endregion

        #region bubble sort

        [TestMethod()]
        public void bubble_sort_not_null_test()
        {
            scrambled.Add(em4);
            Assert.IsNotNull(main.myBubbleSort(scrambled));
        }

        [TestMethod()]
        public void bubble_sort_no_lost_test()
        {
            scrambled.Add(em4);
            scrambled.Add(em5);
            scrambled.Add(em2);
            scrambled.Add(em6);

            Assert.AreEqual(main.myBubbleSort(scrambled).Count, 4);
        }

        [TestMethod()]
        public void bubble_sort_5_middle_elements_test()
        {
            scrambled.Add(em4);
            scrambled.Add(em5);
            scrambled.Add(em2);
            scrambled.Add(em6);
            scrambled.Add(em7);
            //scrambled now contains: [7890, 10000, 4000, 12345, 14000]

            sorted.Add(em2);
            sorted.Add(em4);
            sorted.Add(em5);
            sorted.Add(em6);
            sorted.Add(em7);
            //sorted now contains: [4000, 7890, 10000, 12345, 14000]

            CollectionAssert.AreEqual( main.myBubbleSort(scrambled), sorted);
        }

        [TestMethod()]
        public void bubble_sort_lower_bound_test()
        {
            scrambled.Add(em4);
            scrambled.Add(em5);
            scrambled.Add(em1);
            //scrambled now contains: [7890, 10000, 3000]

            sorted.Add(em1);
            sorted.Add(em4);
            sorted.Add(em5);
            //sorted now contains: [3000, 7890, 10000]

            CollectionAssert.AreEqual(main.myBubbleSort(scrambled), sorted);
        }

        [TestMethod()]
        public void bubble_sort_upper_bound_test()
        {
            scrambled.Add(em9);
            scrambled.Add(em5);
            scrambled.Add(em4);
            //scrambled now contains: [15000, 10000, 7890]

            sorted.Add(em4);
            sorted.Add(em5);
            sorted.Add(em9);
            //sorted now contains: [7890, 10000, 15000]

            CollectionAssert.AreEqual(main.myBubbleSort(scrambled), sorted);
        }

        [TestMethod()]
        public void bubble_sort_both_bounds_test()
        {
            scrambled.Add(em1);
            scrambled.Add(em9);
            scrambled.Add(em5);
            scrambled.Add(em4);
            //scrambled now contains: [3000, 15000, 10000, 7890]

            sorted.Add(em1);
            sorted.Add(em4);
            sorted.Add(em5);
            sorted.Add(em9);
            //sorted now contains: [3000, 7890, 10000, 15000]

            CollectionAssert.AreEqual(main.myBubbleSort(scrambled), sorted);
        }

        [TestMethod()]
        public void bubble_sort_2_exact_test()
        {
            scrambled.Add(em5);
            scrambled.Add(em5);
            scrambled.Add(em1);
            //scrambled now contains: [10000, 10000, 3000]

            sorted.Add(em1);
            sorted.Add(em5);
            sorted.Add(em5);
            //sorted now contains: [3000, 10000, 1000]

            CollectionAssert.AreEqual(main.myBubbleSort(scrambled), sorted);
        }

        [TestMethod()]
        public void bubble_sort_3_exact_test()
        {
            scrambled.Add(em5);
            scrambled.Add(em5);
            scrambled.Add(em5);
            scrambled.Add(em1);

            //scrambled now contains: [10000, 10000, 10000, 3000]

            sorted.Add(em1);
            sorted.Add(em5);
            sorted.Add(em5);
            sorted.Add(em5);
            //sorted now contains: [3000, 10000, 10000, 10000]

            CollectionAssert.AreEqual(main.myBubbleSort(scrambled), sorted);
        }
        #endregion
    }
}
