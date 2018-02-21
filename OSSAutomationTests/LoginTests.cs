using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSSAutomationFramework;
using OSSAutomationTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSAutomationTests
{
    [TestClass]
    public class LoginTests : LoginBaseTests
    {
        [TestMethod]
        public void EMP_Can_Login()
        {
            Assert.IsTrue(LoginPage.IsAtHome, "Failed to login.");
        }
    }
}


