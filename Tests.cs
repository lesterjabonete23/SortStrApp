using System;
using SortStrApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class Tests
{
    [TestMethod]
    public void BubbleSort_Test()
    {
        ISortingStrategy bubbleSort = new BubbleSort();
        string result = bubbleSort.Sort("befdac");
        Assert.AreEqual("abcdef", result);
    }

    [TestMethod]
    public void QuickSort_Test()
    {
        ISortingStrategy quickSort = new Quicksort();
        string result = quickSort.Sort("befdac");
        Assert.AreEqual("abcdef", result);
    }
}