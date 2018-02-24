using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSSAutomationFramework;

namespace OSSAutomationTests
{
    [TestClass]
    public class AddCustomerTests : LoginBaseTests
    {
        [TestMethod]
        public void User_Can_Add_Customer()
        {

            AddCustomer.GoToAddCustomer();
            Assert.IsTrue(AddCustomer.customerIsAdded, "Cannot add customer");
        }
    }
}