using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace OSSAutomationFramework.Settings
{
    public class Permissions
    {
        public static bool empIsAdded = false;
        public static bool groupIsAdded = false;
        public static void GoToPermissions()
        {
            IWebElement settingsButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainNav\"]/ul/li[7]/a/span"), 5);
            settingsButton.Click();
            IWebElement permissionsButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainNav\"]/ul/li[7]/ul/li[1]/a"), 5);
            permissionsButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }

        public static bool IsAtPermissions
        {
            get
            {
                IWebElement emps = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]/div/div[2]/ng-component/div[3]/form/div[1]/div[1]/div/h3/strong"), 5);
                return emps.Text == "EMPs";
            }
        }

        public static void AddEMPInit()
        {
            IWebElement addButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]/div/div[2]/ng-component//button[1]"), 5);
            addButton.Click();
        }

        public static bool IsAtEMP
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement addEMPForm = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]/div[1]/div/div/div/h2/span"), 5);
                return addEMPForm.Text == "Add Employee";
            }
        }

        public static void AddEMP()
        {

            IWebElement mrmrs = Helpers.FindElement(Driver.Instance, By.Name("contactPrefix"), 5);
            var prefix = new SelectElement(mrmrs);
            Helpers.Wait(TimeSpan.FromSeconds(1));
            prefix.SelectByValue("3");

            IWebElement firstName = Helpers.FindElement(Driver.Instance, By.Id("fname"), 5);
            char[] RandomLetters = "hfuiheriughfvidbvfidgkjieiriq".ToCharArray();
            Random r = new Random();
            string firstLetter = RandomLetters[r.Next(0, 25)].ToString();
            string secondLetter = RandomLetters[r.Next(0, 25)].ToString();
            string thirdLetter = RandomLetters[r.Next(0, 25)].ToString();
            string name = firstLetter + secondLetter + thirdLetter;
            firstName.SendKeys(name);

            IWebElement lastName = Helpers.FindElement(Driver.Instance, By.Id("lname"), 5);
            string firstLetter2 = RandomLetters[r.Next(0, 25)].ToString();
            string secondLetter2 = RandomLetters[r.Next(0, 25)].ToString();
            string thirdLetter2 = RandomLetters[r.Next(0, 25)].ToString();
            string surname = firstLetter2 + secondLetter2 + thirdLetter2;
            lastName.SendKeys(surname);

            IWebElement address = Helpers.FindElement(Driver.Instance, By.Name("addres1"), 5);
            address.Clear();
            address.SendKeys("Example Avenue");
            Helpers.Wait(TimeSpan.FromSeconds(1));

            IWebElement postalCode = Helpers.FindElement(Driver.Instance, By.Id("pcode"), 5);
            postalCode.Clear();
            postalCode.SendKeys("10000");

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement empDataButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]/div[2]/div/div/div/button[2]"), 5);
            empDataButton.Click();

            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement empCode = Helpers.FindElement(Driver.Instance, By.Name("empCode"), 5);
            string firstLetter3 = RandomLetters[r.Next(0, 25)].ToString();
            string secondLetter3 = RandomLetters[r.Next(0, 25)].ToString();
            string thirdLetter3 = RandomLetters[r.Next(0, 25)].ToString();
            string code = firstLetter3 + secondLetter3 + thirdLetter3;
            empCode.SendKeys(code);

            bool duplicateEMP = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]//small"), 5).Displayed;

            if (duplicateEMP)
            {
                empCode.Clear();
                empCode.SendKeys(code);
                Helpers.Wait(TimeSpan.FromSeconds(1));
            }

            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement empType = Helpers.FindElement(Driver.Instance, By.Name("empType"), 5);
            Helpers.Wait(TimeSpan.FromSeconds(1));
            var emp = new SelectElement(empType);
            emp.SelectByValue("A");

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement contactNumberButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]/div[2]/div/div/div/button[3]"), 5);
            contactNumberButton.Click();

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement otherDataButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]/div[2]/div/div/div/button[4]"), 5);
            otherDataButton.Click();

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement password = Helpers.FindElement(Driver.Instance, By.Id("password"), 5);
            password.SendKeys("123");

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement confirmPassword = Helpers.FindElement(Driver.Instance, By.Id("confirmpassword"), 5);
            confirmPassword.SendKeys("123");

            IWebElement accountType = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]/div[2]/div/form[4]/div/div[1]/div[3]/fieldset/span/select"), 5);
            accountType.Click();

            IWebElement effectiveData = Helpers.FindElement(Driver.Instance, By.Id("effDate"), 5);
            effectiveData.Clear();
            effectiveData.SendKeys("05/27/2018 20:00");

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement previewDataButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]/div[2]/div/div[1]/div/button[5]"), 5);
            previewDataButton.Click();

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement mainInfoButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]/div[2]/div/div/div/button[1]"), 5);
            mainInfoButton.Click();

            Helpers.Wait(TimeSpan.FromSeconds(3));
            IWebElement saveButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"addEmployee\"]/div[3]//button[contains(text(), 'Save')]"), 5);
            saveButton.Click();

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement empSearch = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]/table/tbody/tr[1]/td[1]"), 5);
            empSearch.Click();

            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement searchColumn = Helpers.FindElement(Driver.Instance, By.Id("Code"), 5);
            searchColumn.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
            searchColumn.SendKeys(code);
            searchColumn.SendKeys(Keys.Enter);
            Helpers.Wait(TimeSpan.FromSeconds(2));
            empIsAdded = true;
        }

        public static void EditEMPItemsInit()
        {
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement emp = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]/table/tbody/tr[1]/td[1]"), 5);
            emp.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement search = Helpers.FindElement(Driver.Instance, By.Id("Code"), 5);
            search.SendKeys("VMO");
            search.SendKeys(Keys.Enter);
            IWebElement empCode = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]/table/tbody/tr[1]/td[1]"), 5);
            IWebElement editButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]/div/div[2]/ng-component/div[3]/div/div[1]/p/button[contains(text(), 'Edit')]"), 5);
            editButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
        }

        public static bool IsAtEditEMPItemsInit
        {
            get
            {
                IWebElement selectItems = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[1]/div/div/h2"), 5);
                return selectItems.Text == "Select Items";
            }
        }

        public static void EditEMPItems()
        {
            IWebElement selectAll = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[3]"), 5);
            selectAll.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement unselectAll = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[4]"), 5);
            unselectAll.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement general = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[2]/div/div/div[1]/div/div/table/tbody/tr[1]/td"), 5);
            general.Click();
        }

        public static bool IsSelected
        {
            get
            {
                IWebElement generalPermission = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[2]/div/div/div[2]/div/div/table/tbody/tr/td"), 5);
                return generalPermission.Text == "General";
            }
        }

        public static void CopyEMPInit()
        {
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement emp = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]/table/tbody/tr[1]/td[1]"), 5);
            emp.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement search = Helpers.FindElement(Driver.Instance, By.Id("Code"), 5);
            search.SendKeys("YOU");
            search.SendKeys(Keys.Enter);
            IWebElement empCode = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]/table/tbody/tr[1]/td[1]"), 5);
            IWebElement copyButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]/div/div[2]/ng-component/div[3]/div/div[1]/p/button[contains(text(), 'Copy')]"), 5);
            copyButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
        }

        public static bool IsAtCopyEMP
        {
            get
            {
                IWebElement copyEMP = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[1]/div/div/h2"), 5);
                return copyEMP.Text == "Copy EMP Permissions";
            }
        }

        public static void CopyEMP()
        {
            IWebElement copy = Helpers.FindElement(Driver.Instance, By.Name("copyEmp"), 5);
            copy.SendKeys("VMO");
            copy.SendKeys(Keys.ArrowDown);
            copy.SendKeys(Keys.Enter);
            IWebElement copyForm = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div"), 5);
            copyForm.Click();
            IWebElement okButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[2]"), 5);
            Helpers.Wait(TimeSpan.FromSeconds(1));
            okButton.Click();
        }

        public static bool IsCopied
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement copyEMP = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]//td[contains(text(), 'Ms. Josa Mo')]"), 5);
                return copyEMP.Text == "Ms. Josa Mo";
            }

        }

        public static void SuspendEMP()
        {
            IWebElement emp = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]//td[1]"), 5);
            emp.Click();
            IWebElement codeSearch = Helpers.FindElement(Driver.Instance, By.Id("Code"), 5);
            codeSearch.Click();
            codeSearch.SendKeys("EE");
            codeSearch.SendKeys(Keys.Enter);
            IWebElement empIsFound = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]//td[1]"), 5);
            empIsFound.Click();
            IWebElement activateButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]//button[4]"), 5);
            activateButton.Click();
        }

        public static bool EMPIsSuspended
        {
            get
            {
                IWebElement activateButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]//button[4]"), 5);
                return activateButton.Text == "Suspend";
            }
        }

        public static void PasswordInit()
        {
            IWebElement emp = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]/table/tbody/tr[1]/td[1]"), 5);
            emp.Click();
            IWebElement searchCode = Helpers.FindElement(Driver.Instance, By.Id("Code"), 5);
            searchCode.Click();
            searchCode.SendKeys("VVV");
            searchCode.SendKeys(Keys.Enter);
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement password = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]//button[5]"), 5);
            password.Click();
        }

        public static bool IsAtPassword
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement password = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"userPasswordChange\"]/div[1]/div/div/h2"), 5);
                return password.Text == "Change Password";
            }
        }

        public static void ChangePassword()
        {
            IWebElement newPassword = Helpers.FindElement(Driver.Instance, By.Id("newpassword"), 5);
            newPassword.Click();
            newPassword.SendKeys("2");
            newPassword.SendKeys(Keys.Enter);
            IWebElement verifyPassword = Helpers.FindElement(Driver.Instance, By.Id("retypepassword"), 5);
            verifyPassword.Click();
            verifyPassword.SendKeys("2");
            verifyPassword.SendKeys(Keys.Enter);
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement saveButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"userPasswordChange\"]//button[1]"), 5);
            saveButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement password = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"userPasswordChange\"]/div[1]/div/div/h2"), 5);
            password.Click();
            IWebElement newPassword2 = Helpers.FindElement(Driver.Instance, By.Id("newpassword"), 5);
            newPassword.Click();
            newPassword.SendKeys("2");
            newPassword.SendKeys(Keys.Enter);
            IWebElement verifyPassword2 = Helpers.FindElement(Driver.Instance, By.Id("retypepassword"), 5);
            verifyPassword.Click();
            verifyPassword.SendKeys("2");
            verifyPassword.SendKeys(Keys.Enter);
            IWebElement saveButton2 = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"userPasswordChange\"]//button[1]"), 5);
            saveButton.Click();
        }

        public static bool PasswordIsChanged
        {
            get
            {
                IWebElement errorMessage = Helpers.FindElement(Driver.Instance, By.Id("errorMessage"), 5);
                return errorMessage.Text == "You cannot reuse old passwords within quarantine period. Enter a new password.";
            }
        }

        public static void EditEMPPermissionsInit()
        {
            IWebElement emp = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]/table/tbody/tr[1]/td[1]"), 5);
            emp.Click();
            IWebElement searchCode = Helpers.FindElement(Driver.Instance, By.Id("Code"), 5);
            searchCode.Click();
            searchCode.SendKeys("YOU");
            searchCode.SendKeys(Keys.Enter);
            //Note: For now, it is a bug that permissions doesn't get enabled after searching for an emp
            IWebElement empIsSearched = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"scrollingdiv\"]//td[contains(text(), 'YOU')]"), 5);
            empIsSearched.Click();
            empIsSearched.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement permissionsButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]//button[contains(text(), 'Permissions')]"), 5);
            permissionsButton.Click();
        }

        public static bool IsAtEditEMPPermissions
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement editEMPPermissions = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container//h2"), 5);
                return editEMPPermissions.Text == "Edit EMP Permissions";
            }
        }

        public static void EditEMPPermissions()
        {
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement category = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container//select"), 5);
            SelectElement dropDown = new SelectElement(category);
            dropDown.SelectByValue("10");
            IWebElement categories = Helpers.FindElement(Driver.Instance, By.XPath("/html/body//span/span"), 5);
            categories.Click();

            dropDown.SelectByValue("12");
            categories.Click();

            dropDown.SelectByValue("1");
            categories.Click();

            dropDown.SelectByValue("9");
            categories.Click();

            dropDown.SelectByValue("3");
            categories.Click();

            dropDown.SelectByValue("2");
            categories.Click();

            dropDown.SelectByValue("4");
            categories.Click();

            dropDown.SelectByValue("8");
            categories.Click();

            dropDown.SelectByValue("5");
            categories.Click();

            dropDown.SelectByValue("6");
            categories.Click();

            dropDown.SelectByValue("11");
            categories.Click();

            dropDown.SelectByValue("7");
            categories.Click();

            dropDown.SelectByValue("13");
            categories.Click();

            dropDown.SelectByValue("14");
            categories.Click();

            dropDown.SelectByValue("16");
            categories.Click();
        }

        public static bool CategoryIsSelected
        {
            get
            {
                IWebElement reports = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[2]/div/div[4]/div[1]/div[1]/tree-root/tree-viewport/div/div/tree-node-collection/div/tree-node/div/tree-node-children/div/tree-node-collection/div/tree-node/div/tree-node-wrapper/div/div/tree-node-content/span"), 5);
                return reports.Text == "Reports";
            }
        }

        public static void GroupPermissions()
        {
            IWebElement groupPermissions = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]//div[2]/a[contains(text(), 'Permission Groups')]"), 5);
            groupPermissions.Click();
        }

        public static bool IsAtGroupPermissions
        {
            get
            {
                IWebElement groupPermissions = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"mainContentDiv\"]//div[3]/form/div[2]/div/div[1]/h3/strong"), 5);
                return groupPermissions.Text == "Security Groups";
            }
        }

        public static void AddGroupEMPInit()
        {
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement addButton = Helpers.FindElement(Driver.Instance, By.CssSelector("#mainContentDiv > div > div.content.slimscroll > ng-component > div.subtabs > div > div:nth-child(2) > p > button:nth-child(1)"), 5);
            addButton.Click();
        }

        public static bool IsAtPermissionGroup
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement permissionGroup = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay//div[1]/div/div/h2"), 5);
                return permissionGroup.Text == "Add Permissions Group";
            }
        }

        public static void AddPermissionGroup()
        {

            IWebElement group = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay//input"), 5);
            group.Click();
            char[] RandomLetters = "hfuiheriughfvidbvfidgkjieiriq".ToCharArray();
            Random r = new Random();
            string firstLetter = RandomLetters[r.Next(0, 25)].ToString();
            string secondLetter = RandomLetters[r.Next(0, 25)].ToString();
            string thirdLetter = RandomLetters[r.Next(0, 25)].ToString();
            string groupName = firstLetter + secondLetter + thirdLetter;
            group.SendKeys("DFG");
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement groupDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body//div[2]/fieldset/div/input"), 5);
            groupDesc.Click();
            char[] RandomLetters2 = "hfuiheriughfvidbvfidgkjieiriq".ToCharArray();
            Random r2 = new Random();
            string first = RandomLetters2[r2.Next(0, 25)].ToString();
            string second = RandomLetters2[r2.Next(0, 25)].ToString();
            string third = RandomLetters2[r2.Next(0, 25)].ToString();
            string groupDecription = first + second + third;
            groupDesc.SendKeys(groupDecription);
            IWebElement category = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay//select"), 5);
            SelectElement dropDown = new SelectElement(category);
            dropDown.SelectByValue("12");
            IWebElement effectiveDate = Helpers.FindElement(Driver.Instance, By.Id("effDate"), 5);
            effectiveDate.Clear();
            effectiveDate.SendKeys("03/15/2018");
            effectiveDate.SendKeys(Keys.Enter);
            IWebElement minCheckBox = Helpers.FindElement(Driver.Instance, By.XPath("/html/body//span[2]/input"), 5);
            minCheckBox.Click();
            IWebElement copyCheckBox = Helpers.FindElement(Driver.Instance, By.XPath("/html/body//span[3]/input"), 5);
            copyCheckBox.Click();
            IWebElement okButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body//div/div[3]//button[2]"), 5);
            okButton.Click();
            bool alreadyExists = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"customerConfirmAmount\"]/div[2]//p]"), 5).Displayed;

            if (alreadyExists)
            {
                IWebElement reEnter = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"customerConfirmAmount\"]/div[2]/div/div/div/blockquote/p"), 5);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                reEnter.Click();
                group.SendKeys(groupName);
                Helpers.Wait(TimeSpan.FromSeconds(1));
            }

            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement empGroupSearch = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"customerConfirmAmount\"]/div[3]/div/div/p/button[1]"), 5);
            empGroupSearch.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement searchColumn = Helpers.FindElement(Driver.Instance, By.Id("Code"), 5);
            searchColumn.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
            searchColumn.SendKeys(groupName);
            searchColumn.SendKeys(Keys.Enter);
            Helpers.Wait(TimeSpan.FromSeconds(2));
            groupIsAdded = true;

        }
    }
}
