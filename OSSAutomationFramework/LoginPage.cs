using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSAutomationFramework
{
    public class LoginPage
    {
        public static void GoToOSS()
        {
            Driver.Instance.Navigate().GoToUrl("https://oss360.developersgrave.com");
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }

        public static void Login()
        {
            IWebElement empField = Helpers.FindElement(Driver.Instance, By.Id("empName"), 5);
            empField.SendKeys("SOL");
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement loginButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/oss360-app/log-in//button[text()='Login']"), 5);
            loginButton.Click();
        }
        public static bool IsAtHome
        {
            get
            {
                IWebElement solUser = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"userInfo\"]/div/h3"), 5);
                return solUser.Text == "Solaborate";
            }
        }
    }
}
