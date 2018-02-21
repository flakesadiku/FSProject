using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSAutomationFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static void Initialize()
        {
            Instance = new ChromeDriver(@"C:\");
            Instance.Manage().Window.Maximize();
        }
        public static void Close()
        {
            Instance.Close();
        }
    }
}
