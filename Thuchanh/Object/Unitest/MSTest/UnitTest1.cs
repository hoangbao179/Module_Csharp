using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unitest.Calculator;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator cal = new Calculator();
        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(cal.Add(1, 1) == 2);
            Assert.IsTrue(cal.Add(2, 2) == 4);
            Assert.IsTrue(cal.Add(4, 1) == 5);
        }
        [TestMethod]
        public void SubTractTest()
        {
            Assert.IsTrue(cal.Subtract(6, 4) == 2);
            Assert.IsTrue(cal.Subtract(9, 4) == 5);

        }
    }
}
