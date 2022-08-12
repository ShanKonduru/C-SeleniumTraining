using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumUnitTests {

    public class BaseTest : SeleniumUnitTest {

        public TestContext TestContext { get; set; }

        [AssemblyInitialize]
        public static new void AssemblyInitialize (TestContext context) {
            SeleniumUnitTest.AssemblyInitialize (context);
        }

        [TestInitialize]
        public override void TestInitialize () {
            base.TestInitialize ();
            Trace.TraceInformation ("Start {0}", this.TestContext.TestName);
        }

        [TestCleanup]
        public override void TestCleanup () {
            Trace.TraceInformation ("End {0}", this.TestContext.TestName);
            base.TestCleanup ();
        }

        [AssemblyCleanup]
        public static new void AssemblyCleanup () {
            SeleniumUnitTest.AssemblyCleanup ();
        }
    }
}