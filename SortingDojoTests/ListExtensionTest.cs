using NUnit.Framework;
using SortingDojo.Extensions;
using System.Collections.Generic;

namespace SortingDojoTests
{
    public class Tests
    {
        private List<int> _list;
        private readonly List<int> _expected = new List<int>() { -23, -19, -6, -3, -1, 0, 2, 4, 6, 7, 8, 9, 9, 17, 18, 19 };

        [SetUp]
        public void Setup()
        {
            _list = new List<int>() { 9, 18, -23, 17, 0, 6, -19, 9, 2, -6, 8, 19, -3, 4, 7, -1 };
        }

        [Test]
        public void BubblekSort_SortsList()
        {
            _list.BubbleSort();
            Assert.AreEqual(_expected, _list);
        }

        [Test]
        public void InsertionSort_SortsList()
        {
            _list.InsertionSort();
            Assert.AreEqual(_expected, _list);
        }

        [Test]
        public void QuickSort_SortsList()
        {
            _list.QuickSort();
            Assert.AreEqual(_expected, _list);
        }
    }
}