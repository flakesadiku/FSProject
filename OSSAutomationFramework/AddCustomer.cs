using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace OSSAutomationFramework
{
    public class AddCustomer
    {
        public static bool customerIsAdded = false;


        public static void GoToAddCustomer()
        {
            IWebElement Support = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainNav\"]/ul/li[2]/a/span"), 20);
            Support.Click();
            System.Threading.Thread.Sleep(2000);



            IWebElement Customers = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainNav\"]/ul/li[2]/ul/li[1]/a"), 20);
            Customers.Click();
            System.Threading.Thread.Sleep(3000);


            IWebElement AddCustomer = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"cusselcont\"]/div[3]/div/div/p/button[1]"), 20);
            AddCustomer.Click();
            System.Threading.Thread.Sleep(3000);


            var MrMrsSelectOption = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"cusAddEditCont\"]/div/div[2]/div[1]/div[1]/fieldset/span/select"), 20);
            SelectElement select = new SelectElement(MrMrsSelectOption);
            System.Threading.Thread.Sleep(3000);
            select.SelectByValue("3");

            IWebElement FirstName1 = Helpers.FindElement(Driver.Instance, By.Id("fname"), 20);
            char[] RandomLetters = "hfuiheriughfvidbvfidgkjieiriq".ToCharArray();
            Random R = new Random();
            string firstLetter = RandomLetters[R.Next(0, 25)].ToString();
            string secondLetter = RandomLetters[R.Next(0, 25)].ToString();
            string thirdLetter = RandomLetters[R.Next(0, 25)].ToString();

            string name = firstLetter + secondLetter + thirdLetter;
            FirstName1.SendKeys(name);
            IWebElement LastName1 = Helpers.FindElement(Driver.Instance, By.Id("lname"), 20);
            string firstLetter1 = RandomLetters[R.Next(0, 25)].ToString();
            string secondLetter1 = RandomLetters[R.Next(0, 25)].ToString();
            string thirdLetter1 = RandomLetters[R.Next(0, 25)].ToString();

            string surname = firstLetter1 + secondLetter1 + thirdLetter1;
            LastName1.SendKeys(surname);
            System.Threading.Thread.Sleep(3000);

            string fullName = " " + name + " " + surname;

            IWebElement address = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"cusAddEditCont\"]/div/div[2]/div[2]/div[1]/fieldset/div/input[1]"), 20);
            address.Click();

            address.SendKeys("Example Avenue");
            System.Threading.Thread.Sleep(1000);



            IWebElement postalCode = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"pcode\"]"), 20);
            System.Threading.Thread.Sleep(2000);
            postalCode.SendKeys("1000");

            IWebElement duplicateAddress = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"duplicateCheck\"]/div[3]/div/div/p/button[4]"), 20);
            duplicateAddress.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement taxPopup = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"geocodePopup\"]/div[1]/div/div/div/h2"), 20);
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"geocodePopup\"]/div[3]/div/div/p/button[2]"), 20);
            cancelButton.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement saveButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/form/div[3]/div[2]/div/p/button[1]"), 20);
            saveButton.Click();
            System.Threading.Thread.Sleep(5000);

            Support.Click();
            Customers.Click();

            IWebElement lastButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"searchButtons\"]/div/div[2]/div[4]/button"), 20);
            lastButton.Click();

            IWebElement searchName = Helpers.FindElement(Driver.Instance, By.Id("txtFieldFName"), 20);
            searchName.Click();
            searchName.SendKeys(name);

            IWebElement searchButton1 = Helpers.FindElement(Driver.Instance, By.CssSelector("#search-leads > button"), 20);
            searchButton1.Click();
            System.Threading.Thread.Sleep(1000);
            var registeredName = Helpers.FindElement(Driver.Instance, By.TagName("tr"), 20);
            string stringRegisteredName = registeredName.Text;


            IWebElement elementTable = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"cusselcont\"]/div[2]/div/div[3]/div/div/div/table"), 20);
            List<IWebElement> trElement = new List<IWebElement>(elementTable.FindElements(By.TagName("tr")));
            if (trElement.Count > 0)

            {
                List<IWebElement> tdElement = new List<IWebElement>(elementTable.FindElements(By.XPath("//td[1]")));
                foreach (var firstTdElement in tdElement)
                {

                    string strRowData = "";
                    strRowData = strRowData + " " + firstTdElement.Text;
                    System.Threading.Thread.Sleep(2000);

                    string FullName = fullName.Trim();
                    customerIsAdded = true;

                }

            }

        }
    }
}