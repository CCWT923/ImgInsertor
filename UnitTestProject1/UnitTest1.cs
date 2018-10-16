using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExcelImageInsert;

namespace UnitTestProject1
{
    [TestClass]
    public class NameUnitTest
    {
        [TestMethod]
        public void GetNumberTest()
        {
            NameUnit nameUnit = new NameUnit();
            Assert.AreEqual(nameUnit.GetNumber("ABCDEFG123个"), 123);
        }
    }
}
