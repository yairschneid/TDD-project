using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;

namespace testing_sort
{
    [TestClass]
    public class UnitTest1
    {
        public Main main;

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(mysort(new int[] { 1, 3, 2 }), new int[] { 1, 2, 3 });
            Assert.AreEqual(4 + 4, 8);
        }
    }
}
