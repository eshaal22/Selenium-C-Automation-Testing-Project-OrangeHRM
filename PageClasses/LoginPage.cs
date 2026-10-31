using OpenQA.Selenium;
using software_assignment.LocatorFile;

namespace software_assignment
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(By.XPath(LocatorClass.UserName))
                  .SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(By.XPath(LocatorClass.Password))
                  .SendKeys(password);
        }

        public void ClickLogin()
        {
            driver.FindElement(By.XPath(LocatorClass.LoginButton))
                  .Click();
        }

        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }
    }
}