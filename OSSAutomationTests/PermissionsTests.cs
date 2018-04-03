using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSSAutomationFramework.Settings;

namespace OSSAutomationTests.Settings
{
    [TestClass]
    public class PermissionsTests : LoginBaseTests
    {
        [TestMethod]
        public void User_Can_Go_To_Permissions()
        {
            Permissions.GoToPermissions();
            Assert.IsTrue(Permissions.IsAtPermissions, "Cannot find Permissions.");
        }

        [TestMethod]
        public void User_Can_Go_To_Add_EMP()
        {
            User_Can_Go_To_Permissions();
            Permissions.AddEMPInit();
            Assert.IsTrue(Permissions.IsAtEMP, "Cannot find Add EMP Form.");
        }

        [TestMethod]
        public void User_Can_Add_EMP()
        {
            User_Can_Go_To_Add_EMP();
            Permissions.AddEMP();
            Assert.IsTrue(Permissions.empIsAdded, "Cannot find the EMP.");
        }

        [TestMethod]
        public void User_Can_Go_To_Edit_EMP_Items()
        {
            User_Can_Go_To_Permissions();
            Permissions.EditEMPItemsInit();
            Assert.IsTrue(Permissions.IsAtEditEMPItemsInit, "Cannot find the Edit EMP.");
        }

        [TestMethod]
        public void User_Can_Edit_EMP_Items()
        {
            User_Can_Go_To_Edit_EMP_Items();
            Permissions.EditEMPItems();
            Assert.IsTrue(Permissions.IsSelected, "Cannot edit permissions.");
        }

        [TestMethod]
        public void User_Can_Go_To_Copy_EMP()
        {
            User_Can_Go_To_Permissions();
            Permissions.CopyEMPInit();
            Assert.IsTrue(Permissions.IsAtCopyEMP, "Cannot find Copy form.");
        }

        [TestMethod]
        public void User_Can_Copy_EMP()
        {
            User_Can_Go_To_Copy_EMP();
            Permissions.CopyEMP();
            Assert.IsTrue(Permissions.IsCopied, "Cannot copy the EMP.");
        }

        [TestMethod]
        public void User_Can_Suspend_EMP()
        {
            User_Can_Go_To_Permissions();
            Permissions.SuspendEMP();
            Assert.IsTrue(Permissions.EMPIsSuspended, "Cannot suspend the EMP.");
        }

        [TestMethod]
        public void User_Can_Go_To_Change_Password()
        {
            User_Can_Go_To_Permissions();
            Permissions.PasswordInit();
            Assert.IsTrue(Permissions.IsAtPassword, "Cannot go to password.");
        }

        [TestMethod]
        public void User_Can_Change_Password()
        {
            User_Can_Go_To_Change_Password();
            Permissions.ChangePassword();
            Assert.IsTrue(Permissions.PasswordIsChanged, "Cannot change password.");
        }

        [TestMethod]
        public void User_Can_Go_To_Edit_EMP_Permissions()
        {
            User_Can_Go_To_Permissions();
            Permissions.EditEMPPermissionsInit();
            Assert.IsTrue(Permissions.IsAtEditEMPPermissions, "Cannot go to edit EMP Permissions.");
        }

        [TestMethod]
        public void User_Can_Edit_EMP_Permissions()
        {
            User_Can_Go_To_Edit_EMP_Permissions();
            Permissions.EditEMPPermissions();
            Assert.IsTrue(Permissions.CategoryIsSelected, "Category is not selected.");
        }

        [TestMethod]
        public void User_Can_Go_To_Group_Permissions()
        {
            Permissions.GoToPermissions();
            Permissions.GroupPermissions();
            Assert.IsTrue(Permissions.IsAtGroupPermissions, "Cannot find group permissions.");
        }

        [TestMethod]
        public void User_Can_Go_To_Add_Group_Permissions()
        {
            User_Can_Go_To_Group_Permissions();
            Permissions.AddGroupEMPInit();
            Assert.IsTrue(Permissions.IsAtPermissionGroup, "Cannot add group permission.");
        }

        [TestMethod]
        public void User_Can_Add_Group_Permissions()
        {
            User_Can_Go_To_Add_Group_Permissions();
            Permissions.AddPermissionGroup();
            Assert.IsTrue(Permissions.groupIsAdded, "Cannot add groupEMP.");
        }

    }
}

