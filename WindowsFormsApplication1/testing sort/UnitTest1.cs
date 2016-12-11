using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System.Collections.Generic;

namespace testing_sort
{
    [TestClass]
    public class UnitTest1
    {
        public Main main;
        public List<Employee2> scrambled;
        public List<Employee2> sorted;
        [TestInitialize]
        public void Initialize() {
            main = new Main();
            scrambled = new List<Employee2>();
            sorted = new List<Employee2>();
        }


        [TestMethod]
        public void TestMethod2()
        {

            Employee2 em1 = new Employee2(10000);
            Employee2 em2 = new Employee2(5000);

            scrambled.Add(em1);
            scrambled.Add(em2);

            sorted.Add(em1);
            sorted.Add(em2);
            
            CollectionAssert.AreEqual( main.sort_list (scrambled), sorted);
            
           

        }
        
    }
}
