using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalculator
{
    [TestClass]
    public class MyCalculatorUnitTest
    {
        [TestMethod]
        public void TestAddMethod()
        {
            double operand1= 10;
            double operand2=20;
            double result = MyCalculator.Add (operand1, operand2);
            Assert.AreEqual (operand1 + operand2, result, "Add Method Failed");
        }
        [TestMethod]
        public void NegativeTestAddMethod()
        {
            double operand1= 10;
            double operand2=20;
            double result = MyCalculator.Add (operand1, operand2);
            Assert.AreNotEqual (operand1 * operand2, result, "Add Method Failed");
        }
    }
}
