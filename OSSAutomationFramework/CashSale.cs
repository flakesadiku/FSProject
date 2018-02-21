using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;



namespace OSSAutomationFramework

{
    public class CashSale
    {
        public static void GoToCashSale()
        {
            IWebElement cashSaleButton = Helpers.FindElement(Driver.Instance, By.LinkText("Cash Sale"), 20);
            cashSaleButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement okButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[1]"), 20);
            okButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
        }
        public static bool IsAtCashSale
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement cashSaleDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[1]/div/div[1]/a"), 10);
                return cashSaleDesc.Text == "Create Invoice Detail";
            }
        }



        public static void AddItem()
        {
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement Formclick = Helpers.FindElement(Driver.Instance, By.XPath(" //div[@class='mainpopup hide-lables ngdialog-content animated slideInUp']"), 10);
            Formclick.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement addButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/button[1]"), 10);
            addButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement addButtonRow = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[2]/div/div[1]/div[1]/div/pos-details-table/div/div/table/tbody/tr/td[1]/fieldset/div/div[1]/input"), 10);
            addButtonRow.SendKeys("IP002B");
            addButtonRow.SendKeys(Keys.Enter);

        }
        public static bool AvailableQuantityPopup
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement availableQuantityDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/quantity-exceeded/div/div[1]/div/div/h2"), 10);
                return availableQuantityDesc.Text == "Available Quantity Exceeded";
            }
        }



        public static void IgnoreButton()
        {
            IWebElement ignoreButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/quantity-exceeded/div/div[2]/div/div[3]/div[2]/button"), 10);
            ignoreButton.Click();

        }



        public static void AddSecondItem()
        {
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement Formclick = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[2]"), 10);
            Formclick.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement addButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/button[1]"), 10);
            addButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement addButtonRow = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[2]/div/div[1]/div[1]/div/pos-details-table/div/div/table/tbody/tr[2]/td[1]/fieldset/div/div[1]/input"), 10);
            addButtonRow.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            addButtonRow.SendKeys("IP002W");
            addButtonRow.SendKeys(Keys.Enter);

        }

        public static bool AddSerialNumbersPopup
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement addSerialNumbersDesc = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/h2"), 10);
                return addSerialNumbersDesc.Text == "Add Serial Numbers";
            }
        }



        public static void SerialNumberField()
        {
            IWebElement serialNumberField = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[2]/div/div/div[3]/div[2]/fieldset/div[1]/div"), 10);
            serialNumberField.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement randomSerialNumber = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"submenu headernotifications\"]/div[3]"), 10);
            randomSerialNumber.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
            IWebElement doneButton = Helpers.FindElement(Driver.Instance, By.XPath("//p/button[contains(.,'Done')]"), 10);
            doneButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));


        }



        public static void PropertiesButton()
        {
            IWebElement propertiesButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/button"), 10);
            propertiesButton.Click();

        }


        public static void Information_CheckStock()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement checkStockButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[1]"), 10);
            checkStockButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool CheckStockForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement checkStockDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/view-products/div/div[1]/div[1]/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return checkStockDesc.Text == "Check Stock";


            }
        }



        public static void CancelCheckStock()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Information_Photo()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement photoButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[2]"), 10);
            photoButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool PhotoForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement photoDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/view-photo/div/div[2]/div/div[1]/div/h3"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return photoDesc.Text == "Photo";


            }
        }



        public static void CancelPhotoForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p[@id='ngdialog2-aria-describedby']/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }




        public static void Information_Accessories()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement accessoriesButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[3]"), 10);
            accessoriesButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool AccessoriesForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement accessoriesDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/view-accessories/div/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return accessoriesDesc.Text == "Accessories";


            }
        }



        public static void CancelAccessoriesForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }




        public static void Information_Substitutions()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement subtitutionsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[4]"), 10);
            subtitutionsButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool SubstitutionsForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement substitutionsDesc = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"viewSubstitutes\"]/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return substitutionsDesc.Text == "Substitutes";


            }
        }



        public static void CancelSubstitutionsForm()
        {
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"viewSubstitutes\"]/div[3]/div/div/p/button[3]"), 10);
            cancelButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Information_Pricing()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement pricingButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[5]"), 10);
            pricingButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool PricingForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement pricingDesc = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"viewPricing\"]/div[2]/div/div[1]/div/h3/strong"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return pricingDesc.Text == "Item";


            }
        }



        public static void CancelPricingForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Information_Vendors()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement vendorsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[6]"), 10);
            vendorsButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool VendorsForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement vendorsDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/vendors/div/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return vendorsDesc.Text == "Vendors";


            }
        }



        public static void CancelVendorsForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }




        public static void Information_On_Order()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement onOrderButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[7]"), 10);
            onOrderButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool OnOrderForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement onOrderDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/on-order/div/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return onOrderDesc.Text == "On Order";


            }
        }



        public static void CancelOnOrderForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }




        public static void Information_Purchase_History()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement onOrderButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[8]"), 10);
            onOrderButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool PurchaseHistoryForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement purchaseHistoryDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[1]/div[1]/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return purchaseHistoryDesc.Text == "Purchases";


            }
        }



        public static void CancelPurchaseHistoryForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Information_Memos()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement memosButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[9]"), 10);
            memosButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool MemosForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement memosDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/view-memo/div/div[1]/div/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return memosDesc.Text == "Item Memo";


            }
        }



        public static void CancelMemosForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Information_Warranty_Maintenance()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement warrantyMaintenanceButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[10]"), 10);
            warrantyMaintenanceButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool WarrantyMaintenanceForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement warrantyMaintenanceDesc = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/h3/strong[contains(.,'Warranty')]"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return warrantyMaintenanceDesc.Text == "Warranty";
            }
        }



        public static void CancelWarrantyMaintenanceForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }




        public static void Information_Price_Book()
        {
            IWebElement informationButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class=\"subwrap filterfull\"]/a[contains(.,\"Information\")]"), 10);
            Actions infoButton = new Actions(Driver.Instance);
            infoButton.MoveToElement(informationButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement priceBookButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[1]/div/a/oss-submenu/div/a[11]"), 10);
            priceBookButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool PriceBookForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement priceBookDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/price-books/div/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return priceBookDesc.Text == "Price Books";


            }
        }



        public static void CancelPriceBookForm()
        {
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/price-books/div/div[3]/div/div/p/button[3]"), 10);
            cancelButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Transactions_Transfer()
        {
            IWebElement transactionsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[2]/div/a"), 10);
            Actions transButton = new Actions(Driver.Instance);
            transButton.MoveToElement(transactionsButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement transferButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[2]/div/a/oss-submenu/div/a[1]"), 10);
            transferButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool TransferForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement transferDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[1]/div[1]/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return transferDesc.Text == "Transfer Stock";


            }
        }



        public static void CancelTransferForm()
        {
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[2]"), 10);
            cancelButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Transactions_Requisition()
        {
            IWebElement transactionsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[2]/div/a"), 10);
            Actions transButton = new Actions(Driver.Instance);
            transButton.MoveToElement(transactionsButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement requisitionButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[2]/div/a/oss-submenu/div/a[2]"), 10);
            requisitionButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool RequisitionForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement requisitionDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return requisitionDesc.Text == "Requisition Item";


            }
        }



        public static void CancelRequisitionForm()
        {
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[3]"), 10);
            cancelButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void ChooseEIDs()
        {
            IWebElement chooseEIDsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/a[1]"), 10);
            chooseEIDsButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
        }
        public static bool ChooseEIDsForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement chooseEIDsDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[2]/div/div/div[1]/div/h3"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return chooseEIDsDesc.Text == "Serial Numbers";


            }
        }



        public static void CancelChooseEIDsForm()
        {
            IWebElement doneButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[3]"), 10);
            doneButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void AssignEMPs_Commissions()
        {
            IWebElement assignEMPsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[3]/div/a"), 10);
            Actions assignEmpsButton = new Actions(Driver.Instance);
            assignEmpsButton.MoveToElement(assignEMPsButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement commissionsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/oss-subwrap[3]/div/a/oss-submenu/div/a"), 10);
            commissionsButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool CommissionsForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement commissionsDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/assign-emps/div/div[2]/div[1]/div[1]/div[1]/h3"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return commissionsDesc.Text == "Commission Rate";


            }
        }



        public static void CancelCommissionsForm()
        {
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/assign-emps/div/div[3]/div/div/p/button[2]"), 10);
            cancelButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }


        public static void Price_Override()
        {
            IWebElement priceOverideButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-properties-button/oss-subwrap/div/oss-submenu/div/a[2]"), 10);
            priceOverideButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(1));
        }
        public static bool PriceOverrideForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement priceOverrideDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/pricing-override/div/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return priceOverrideDesc.Text == "Pricing Override";


            }
        }



        public static void CancelPriceOverrideForm()
        {
            IWebElement CancelButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/pricing-override/div/div[3]/div/div/p/button[2]"), 10);
            CancelButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }





        public static void OptionsButton()
        {
            IWebElement optionsButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='subwrap']/button[contains(text(),'Options')]"), 10);
            optionsButton.Click();

        }
        public static bool OptionsSubMenu
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement optionsSubMenu = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='submenu droplinks dropup']/a[contains(text(),'Comment')]"), 10);
                return optionsSubMenu.Text == "Comment";
            }
        }



        public static void Ship()
        {
            IWebElement shipButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='submenu droplinks dropup']/a[contains(text(),'Ship')]"), 10);
            shipButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool ShipForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement shipDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return shipDesc.Text == "Shipping";


            }
        }



        public static void CancelShipForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(.,'OK')]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Adjustments_Refund()
        {
            IWebElement adjustmentsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-options-button/oss-subwrap/div/oss-submenu/div/oss-subwrap/div/a"), 10);
            Actions adjButton = new Actions(Driver.Instance);
            adjButton.MoveToElement(adjustmentsButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement refundButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-options-button/oss-subwrap/div/oss-submenu/div/oss-subwrap/div/a/oss-submenu/div/a[3]"), 10);
            refundButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool RefundForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement refundDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[1]/div/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return refundDesc.Text == "Refund";


            }
        }



        public static void CancelRefundForm()
        {
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[3]"), 10);
            cancelButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Adjustments_Void()
        {
            IWebElement adjustmentsButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-options-button/oss-subwrap/div/oss-submenu/div/oss-subwrap/div/a"), 10);
            Actions adjButton = new Actions(Driver.Instance);
            adjButton.MoveToElement(adjustmentsButton).Perform();
            System.Threading.Thread.Sleep(2000);
            IWebElement voidButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-options-button/oss-subwrap/div/oss-submenu/div/oss-subwrap/div/a/oss-submenu/div/a[4]"), 10);
            voidButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool VoidForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement voidDesc = Helpers.FindElement(Driver.Instance, By.XPath("//*[@id=\"customerVoid\"]/div[1]/div[1]/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return voidDesc.Text == "Void";


            }
        }



        public static void CancelVoidForm()
        {
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/ng-component/div/div[3]/div/div/p/button[3]"), 10);
            Actions actions = new Actions(Driver.Instance);
            actions.MoveToElement(cancelButton);
            actions.Perform();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }



        public static void Installment_Bill()
        {
            IWebElement installmentBillButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/pos-options-button/oss-subwrap/div/oss-submenu/div/a[1]"), 10);
            installmentBillButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool InstallmentBillForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement installmentBillDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/app-installment-bill/div/div[1]/div/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return installmentBillDesc.Text == "Installment-Bill";


            }
        }



        public static void CancelInstallmentBillForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/app-installment-bill/div/div[3]/div/div/p/button[2]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }




        public static void Comment()
        {
            IWebElement commentButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='submenu droplinks dropup']/a[contains(text(),'Comment')]"), 10);
            commentButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }
        public static bool CommentForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement commentDesc = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/h2[contains(text(),'Comment')]"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return commentDesc.Text == "Comment";


            }
        }



        public static void CancelCommentForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/comment-popup/div/div[3]/div/div/p/button[1]"), 10);
            OKButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));

        }



        public static void Invoice()
        {
            IWebElement invoiceButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/button[3]"), 10);
            invoiceButton.Click();
            Helpers.Wait(TimeSpan.FromSeconds(2));
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(text(),'OK')]"), 10);
            OKButton.Click();
        }

        public static bool InvoiceForm
        {
            get
            {
                Helpers.Wait(TimeSpan.FromSeconds(1));
                IWebElement invoiceDesc = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay[2]/bs-modal-container/div/div/close-invoice/div/div[1]/div[1]/div/h2"), 10);
                Helpers.Wait(TimeSpan.FromSeconds(1));
                return invoiceDesc.Text == "Close Invoice";


            }
        }



        public static void CancelInvoiceForm()
        {
            IWebElement OKButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(text(),'OK')]"), 10);
            Actions actions = new Actions(Driver.Instance);
            actions.MoveToElement(OKButton);
            actions.Perform();
            Helpers.Wait(TimeSpan.FromSeconds(2));
        }



        public static void DeleteButton()
        {
            IWebElement elementTable = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[2]/div/div[1]/div[1]/div/pos-details-table/div/div/table"), 10);
            List<IWebElement> trElement = new List<IWebElement>(elementTable.FindElements(By.TagName("tr")));
            if (trElement.Count > 0)

            {
                IWebElement deleteButton = Helpers.FindElement(Driver.Instance, By.XPath("/html/body/modal-overlay/bs-modal-container/div/div/ng-component/div/div[3]/div/div/div/p/button[2]"), 10);
                deleteButton.Click();
                Helpers.Wait(TimeSpan.FromSeconds(2));
                IWebElement confirmDeletion = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(text(),'Yes')]"), 10);
                confirmDeletion.Click();
                Helpers.Wait(TimeSpan.FromSeconds(1));


            }
        }



        public static void CancelButton()
        {
            IWebElement cancelButton = Helpers.FindElement(Driver.Instance, By.XPath("//div[@class='grid_12']/p/button[contains(text(),Cancel)]"), 10);
            cancelButton.Click();

        }

    }

}
