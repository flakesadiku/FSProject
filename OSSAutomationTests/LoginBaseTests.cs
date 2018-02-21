using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSSAutomationFramework;

namespace OSSAutomationTests
{
    [TestClass]
    public class LoginBaseTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoToOSS();
            LoginPage.Login();
        }
        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
