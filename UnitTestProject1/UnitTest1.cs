using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;
using System;
using ImTools;

namespace UnitTestProject1
{
    [TestClass()]
    public class GenericList_NodeTest
    {

        public void DataTestHelper<T>()
            where T : IComparable
        {
            GenericMaxVAl<T> target = new GenericMaxVAl<T>(T[] Val); // TODO: Initialize to an appropriate value
            T expected = default(T); 
            T actual;
            target.Data = expected;
            actual = target.Data;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DataTest()
        {
            Assert.Inconclusive("No appropriate type parameter is found to satisfies the type constraint(s) of T. " +
            "Please call DataTestHelper<T>() with appropriate type parameters.");
        }
    }
}
