
using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using software_assignment.LocatorFile;

namespace software_assignment
{
    public class UserManagementPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public UserManagementPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        public void EnterSearchUsername(string username)
        {
            IWebElement field = wait.Until(d =>
                d.FindElement(By.XPath(LocatorClass.SearchUsername)));

            field.Clear();
            field.SendKeys(username);
        }

        public void SelectAdminRole()
        {
            IWebElement dropdown = wait.Until(d =>
                d.FindElement(By.XPath(
                    "//label[normalize-space()='User Role']/../following-sibling::div//div[contains(@class,'oxd-select-text')]"
                )));

            dropdown.Click();

            IWebElement adminOption = wait.Until(d =>
                d.FindElement(By.XPath(
                    "//div[@role='option']//span[normalize-space()='Admin']"
                )));

            adminOption.Click();
        }

        public void ClickSearch()
        {
            wait.Until(d =>
                d.FindElement(By.XPath(LocatorClass.SearchButton))
            ).Click();
        }

        public void ClickReset()
        {
            wait.Until(d =>
                d.FindElement(By.XPath(LocatorClass.ResetButton))
            ).Click();
        }

        public bool IsUsernameInResults(string username)
        {
            try
            {
                return wait.Until(d =>
                    d.FindElements(By.XPath(
                        "//div[contains(@class,'oxd-table-body')]//div[contains(@class,'oxd-table-row')]"
                    )).Any(row =>
                        row.FindElements(By.XPath(
                            "./div[2]//div"
                        )).Any(cell =>
                            cell.Text.Trim().Equals(
                                username,
                                StringComparison.OrdinalIgnoreCase
                            )
                        )
                    )
                );
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public bool IsUsernameFieldEmpty()
        {
            IWebElement field = wait.Until(d =>
                d.FindElement(By.XPath(
                    "//label[normalize-space()='Username']/../following-sibling::div//input"
                )));

            return string.IsNullOrWhiteSpace(field.GetAttribute("value"));
        }
    }
}
