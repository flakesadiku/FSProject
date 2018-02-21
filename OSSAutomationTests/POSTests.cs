using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSSAutomationFramework;
using OSSAutomationTests;

namespace OSSAutomationTests
{
    [TestClass]
    public class POSTests : LoginBaseTests
    {

        [TestMethod]
        public void User_Can_Go_To_POS()
        {
            POSPage.GoToPOS();

            Assert.IsTrue(POSPage.IsAtPOS, "POS Page is not opened.");
        }
    }
}


