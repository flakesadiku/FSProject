using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OSSAutomationFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OSSAutomationFramework
{
    public class POSPage
    {
        public static void GoToPOS()
        {
            IWebElement posButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainNav\"]/ul/li[3]/a/span"), 5);
            posButton.Click();
        }
        public static bool IsAtPOS
        {
            get
            {
                IWebElement checkStock = Helpers.FindElement(Driver.Instance, By.LinkText("Check Stock"), 5);
                return checkStock.Text == "Check Stock";
            }
        }
    }
}
