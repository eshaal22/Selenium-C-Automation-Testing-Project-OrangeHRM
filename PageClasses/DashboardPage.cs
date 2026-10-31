using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using software_assignment.LocatorFile;

namespace software_assignment
{
    public class DashboardPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public bool IsDashboardDisplayed()
        {
            try
            {
                return wait.Until(d =>
                    d.Url.Contains("/dashboard/index")
                );
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}