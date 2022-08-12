using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalculator {
    [TestClass]
    public class MyCalculatorUnitTest {

        [AssemblyInitialize]
        public static void AssemblyInitialize (TestContext context) {
            Console.WriteLine ("AssemblyInitialize");
        }

        [ClassInitialize]
        public static void ClassInitialize (TestContext context) {
            Console.WriteLine ("ClassInitialize");
        }

        [TestInitialize]
        public virtual void TestInitialize () {
            Console.WriteLine ("TestInitialize");
        }

        [TestCleanup]
        public virtual void TestCleanup () {
            Console.WriteLine ("TestCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanup () {
            Console.WriteLine ("ClassCleanup");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup () {
            Console.WriteLine ("AssemblyCleanup");
        }

        [TestCategory ("Positives")]
        [TestMethod]
        public void TestAddMethod () {
            double operand1 = 10;
            double operand2 = 20;
            double result = MyCalculator.Add (operand1, operand2);
            Assert.AreEqual (operand1 + operand2, result, "Add Method Failed");
        }

        [TestCategory ("Negative")]
        [TestMethod]
        public void NegativeTestAddMethod () {
            double operand1 = 10;
            double operand2 = 20;
            double result = MyCalculator.Add (operand1, operand2);
            Assert.AreNotEqual (operand1 * operand2, result, "Add Method Failed");
        }
    }
}