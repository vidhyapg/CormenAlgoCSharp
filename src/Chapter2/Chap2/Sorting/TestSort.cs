using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
namespace Sorting
{
    [TestClass]
    public class TestSort
    {
        [TestMethod]
        public void TestInsertionSort_5Elements()
        {
            int[] array = {4,5,7,2,1,9};
            int[] sameArray = {4,5,7,2,1,9};
            InsertionSort.Sort(array);
            Assert.IsTrue(array.IsArraySorted());
            Array.Sort(sameArray);
            Assert.IsTrue(array.AreArraySame(sameArray));
            array.PrintArray();
        }

    }
}
