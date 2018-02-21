using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSSAutomationFramework;
using OSSAutomationTests;

namespace OSSAutomationTests.POS
{
    [TestClass]
    public class POSBaseTests : LoginBaseTests
    {
        [TestInitialize]
        [TestMethod]
        public void Go_To_POS()
        {
            POSPage.GoToPOS();
        }
    }
}
