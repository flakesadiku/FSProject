
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSSAutomationFramework;
using OSSAutomationTests.POS;

namespace OSSAutomationTests
{
    [TestClass]
    public class CashSaleTests : POSBaseTests
    {
        [TestMethod]
        public void User_Can_Go_To_Cash_Sale()
        {
            CashSale.GoToCashSale();
            Assert.IsTrue(CashSale.IsAtCashSale, "Can not be found.");
        }

        [TestMethod]
        public void User_Can_Add_Item()
        {
            User_Can_Go_To_Cash_Sale();

            CashSale.AddItem();
            Assert.IsTrue(CashSale.AvailableQuantityPopup, "Can not be found.");

            CashSale.IgnoreButton();

            CashSale.AddSecondItem();
            Assert.IsTrue(CashSale.AvailableQuantityPopup, "Can not be found.");

            CashSale.IgnoreButton();
            Assert.IsTrue(CashSale.AddSerialNumbersPopup, "Can not be found ");

            CashSale.SerialNumberField();
        }

        [TestMethod]
        public void User_Can_Go_To_Properties()
        {
            User_Can_Add_Item();
            CashSale.PropertiesButton();
        }

        [TestMethod]
        public void User_Can_Go_To_CheckStock()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_CheckStock();
            Assert.IsTrue(CashSale.CheckStockForm, "Can not be found");
            CashSale.CancelCheckStock();
        }

        [TestMethod]
        public void User_Can_Go_To_Photo()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Photo();
            Assert.IsTrue(CashSale.PhotoForm, "Can not be found");
            CashSale.CancelPhotoForm();

        }

        [TestMethod]
        public void User_Can_Go_To_Accessories()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Accessories();
            Assert.IsTrue(CashSale.AccessoriesForm, "Can not be found");
            CashSale.CancelAccessoriesForm();

        }

        [TestMethod]
        public void User_Can_Go_To_Substitutions()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Substitutions();
            Assert.IsTrue(CashSale.SubstitutionsForm, "Can not be found");
            CashSale.CancelSubstitutionsForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Pricing()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Pricing();
            Assert.IsTrue(CashSale.PricingForm, "Can not be found");
            CashSale.CancelPricingForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Vendors()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Vendors();
            Assert.IsTrue(CashSale.VendorsForm, "Can not be found");
            CashSale.CancelVendorsForm();
        }

        [TestMethod]
        public void User_Can_Go_To_On_Order()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_On_Order();
            Assert.IsTrue(CashSale.OnOrderForm, "Can not be found");
            CashSale.CancelOnOrderForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Purchase_History()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Purchase_History();
            Assert.IsTrue(CashSale.PurchaseHistoryForm, "Can not be found");
            CashSale.CancelPurchaseHistoryForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Memos()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Memos();
            Assert.IsTrue(CashSale.MemosForm, "Can not be found");
            CashSale.CancelMemosForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Warranty_Maintenance()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Warranty_Maintenance();
            Assert.IsTrue(CashSale.WarrantyMaintenanceForm, "Can not be found");
            CashSale.CancelWarrantyMaintenanceForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Price_Book()
        {
            User_Can_Go_To_Properties();
            CashSale.Information_Price_Book();
            Assert.IsTrue(CashSale.PriceBookForm, "Can not be found");
            CashSale.CancelPriceBookForm();
        }


        [TestMethod]
        public void User_Can_Go_To_Transactions_Transfer()
        {
            User_Can_Go_To_Properties();
            CashSale.Transactions_Transfer();
            Assert.IsTrue(CashSale.TransferForm, "Can not be found");
            CashSale.CancelTransferForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Transactions_Requisition()
        {
            User_Can_Go_To_Properties();
            CashSale.Transactions_Requisition();
            Assert.IsTrue(CashSale.RequisitionForm, "Can not be found");
            CashSale.CancelRequisitionForm();
        }

        [TestMethod]
        public void User_Can_Go_To_ChooseEIDs()
        {
            User_Can_Go_To_Properties();
            CashSale.ChooseEIDs();
            Assert.IsTrue(CashSale.ChooseEIDsForm, "Can not be found");
            CashSale.CancelChooseEIDsForm();
        }

        [TestMethod]
        public void User_Can_Go_To_AssignEMPs_Commissions()
        {
            User_Can_Go_To_Properties();
            CashSale.AssignEMPs_Commissions();
            Assert.IsTrue(CashSale.CommissionsForm, "Can not be found");
            CashSale.CancelCommissionsForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Price_Override()
        {
            User_Can_Go_To_Properties();
            CashSale.Price_Override();
            Assert.IsTrue(CashSale.PriceOverrideForm, "Can not be found");
            CashSale.CancelPriceOverrideForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Options()
        {
            User_Can_Go_To_Cash_Sale();
            CashSale.OptionsButton();
            Assert.IsTrue(CashSale.OptionsSubMenu, "Can not be found");
        }

        [TestMethod]
        public void User_Can_Go_To_Ship()
        {
            User_Can_Add_Item();
            CashSale.OptionsButton();
            CashSale.Ship();
            Assert.IsTrue(CashSale.ShipForm, "Can not be found");
            CashSale.CancelShipForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Adjustments_Void()
        {
            User_Can_Add_Item();
            CashSale.OptionsButton();
            CashSale.Adjustments_Void();
            Assert.IsTrue(CashSale.VoidForm, "Can not be found");
            CashSale.CancelVoidForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Installment_Bill()
        {
            User_Can_Go_To_Options();
            CashSale.Installment_Bill();
            Assert.IsTrue(CashSale.InstallmentBillForm, "Can not be found");
            CashSale.CancelInstallmentBillForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Comment()
        {
            User_Can_Go_To_Options();
            CashSale.Comment();
            Assert.IsTrue(CashSale.CommentForm, "Can not be found");
            CashSale.CancelCommentForm();
        }

        [TestMethod]
        public void User_Can_Go_To_Invoice()
        {
            User_Can_Add_Item();
            CashSale.Invoice();
            Assert.IsTrue(CashSale.InvoiceForm, "Can not be found");
            CashSale.CancelInvoiceForm();
        }

        [TestMethod]
        public void User_Can_Delete_Item()
        {
            User_Can_Add_Item();
            CashSale.DeleteButton();
            CashSale.CancelButton();
        }
    }
}
