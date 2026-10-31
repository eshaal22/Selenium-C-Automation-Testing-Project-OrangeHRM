using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using software_assignment.LocatorFile;

namespace software_assignment
{
    public class AdminPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public AdminPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void ClickAdminMenu()
        {
            IWebElement admin = wait.Until(d =>
                d.FindElement(By.XPath(LocatorClass.AdminMenu))
            );

            admin.Click();
        }

        public bool IsAdminPageDisplayed()
        {
            try
            {
                return wait.Until(d =>
                    d.FindElements(By.XPath(LocatorClass.AdminHeading)).Count > 0
                    &&
                    d.FindElement(By.XPath(LocatorClass.AdminHeading)).Displayed
                );
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}