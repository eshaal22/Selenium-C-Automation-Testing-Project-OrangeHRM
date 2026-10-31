
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace software_assignment
{
    [TestClass]
    public class UnitTest1 : BaseClass
    {
        // TEST 1: Login and Admin Page
        [TestMethod]
        public void OrangeHRMAdminTest()
        {
            Setup();

            try
            {
                Console.WriteLine("Step 1: Opening OrangeHRM...");
                WaitForTest(3);

                string username = JsonReader.GetTestData("Username");
                string password = JsonReader.GetTestData("Password");

                Console.WriteLine("Step 2: Logging in...");
                LoginPage loginPage = new LoginPage(driver!);
                loginPage.Login(username, password);
                WaitForTest(5);

                Console.WriteLine("Step 3: Checking Dashboard...");
                DashboardPage dashboard = new DashboardPage(driver!);

                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(
                    dashboard.IsDashboardDisplayed(),
                    "Dashboard was not displayed."
                );

                WaitForTest(3);

                Console.WriteLine("Step 4: Opening Admin page...");
                AdminPage adminPage = new AdminPage(driver!);
                adminPage.ClickAdminMenu();
                WaitForTest(5);

                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(
                    adminPage.IsAdminPageDisplayed(),
                    "Admin page was not displayed."
                );

                Console.WriteLine("Admin page test passed!");
                WaitForTest(10);
            }
            finally
            {
                // Browser will remain open if BaseClass.TearDown()
                // has an empty method body.
                TearDown();
            }
        }

        // TEST 2: User Management Username Search
        [TestMethod]
        public void UserManagementSearchTest()
        {
            Setup();

            try
            {
                Console.WriteLine("Step 1: Opening OrangeHRM...");
                WaitForTest(3);

                string username = JsonReader.GetTestData("Username");
                string password = JsonReader.GetTestData("Password");

                Console.WriteLine("Step 2: Logging in...");
                LoginPage loginPage = new LoginPage(driver!);
                loginPage.Login(username, password);
                WaitForTest(5);

                Console.WriteLine("Step 3: Opening Admin page...");
                AdminPage adminPage = new AdminPage(driver!);
                adminPage.ClickAdminMenu();
                WaitForTest(5);

                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(
                    adminPage.IsAdminPageDisplayed(),
                    "Admin page was not displayed."
                );

                Console.WriteLine("Step 4: Searching username Admin...");
                UserManagementPage userPage =
                    new UserManagementPage(driver!);

                userPage.EnterSearchUsername("Admin");
                WaitForTest(3);

                Console.WriteLine("Step 5: Clicking Search...");
                userPage.ClickSearch();
                WaitForTest(5);

                Console.WriteLine("Step 6: Verifying search result...");

                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(
                    userPage.IsUsernameInResults("Admin"),
                    "Username Admin was not found in search results."
                );

                Console.WriteLine("User Management search test passed!");

                Console.WriteLine("Viewing results for 20 seconds...");
                WaitForTest(20);
            }
            finally
            {
                TearDown();
            }
        }
    }
}
