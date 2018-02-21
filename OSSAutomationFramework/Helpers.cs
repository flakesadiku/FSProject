using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSAutomationFramework
{
    public static class Helpers
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
        public static void Wait(TimeSpan timeSpan)
        {
            System.Threading.Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }

        internal static bool FindElement(IWebDriver instance, object displayed, int v)
        {
            throw new NotImplementedException();
        }
    }
}
