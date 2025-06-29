using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListLib;

namespace ListLibUnitTest
{
    [TestClass]
    public class MyListUnitTest
    {
        private MyList<int> _list;
        [TestInitialize]
        public void Init()
        {
            _list = new MyList<int>();
        }

        [TestMethod]
        public void CountEqualsZeroAfterListCreation()
        {
            Assert.AreEqual(0,_list.Count);
        }
        [TestMethod]
        public void CountShouldIncreaseAfterAdding()
        {
            int n = 10;
            for(int i=0; i<n; i++)
                _list.Add(i);
            Assert.AreEqual(n, _list.Count);
        }
        [TestMethod]
        public void ItemsExistsAfterAdding()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
                _list.Add(i);
            int item = 0;
            foreach (var value in _list)
            {
                Assert.AreEqual(item,value);
                item++;
            }
        }
        [TestMethod]
        public void ItemsExistsAfterCreation()
        {
            int[] ints = {7, 0, 5, 4, 66};
            _list = new MyList<int>(ints);
            int i = 0;
            foreach (var value in _list)
            {
                Assert.AreEqual(ints[i], value);
                i++;
            }
            Assert.AreEqual(ints.Length, _list.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionAfterCreationWithNullSequences()
        {
            int[] ints = null;
            _list = new MyList<int>(ints);
        }
        [TestMethod]
        public void CountZeroAfterCreationByEmptySequences()
        {
            int[] ints = new int[0];
            _list = new MyList<int>(ints);
            Assert.AreEqual(ints.Length, _list.Count);
        }
        [TestMethod]
        public void MyTestValueEqualsListElement()
        {
            int[] ints = { 7, 0, 5, 4, 66 };
            _list = new MyList<int>(ints);
            int i = _list.Method(5, _list);
            Assert.AreEqual(i, 2);
        }
        [TestMethod]
        public void MyTestValueEqualsListElementWrong()
        {
            int n = 10;
            int i = 0;
            for (i = 0; i < n; i++)
                _list.Add(i);
            int y = _list.Method(20, _list);
            Assert.AreEqual(y, 10);
        }
        public void MyTestSomeValuesEqualsListElement()
        {
            int[] ints = { 7, 5, 5, 4, 66 };
            _list = new MyList<int>(ints);
            int i = _list.Method(5, _list);
            Assert.AreEqual(i, 1);
        }
    }
}
