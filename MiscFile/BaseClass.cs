
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace software_assignment
{
    public class BaseClass
    {
        public static IWebDriver? driver;

        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.PageLoadStrategy = PageLoadStrategy.Normal;

            driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl(
                "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"
            );

            WebDriverWait wait = new WebDriverWait(
                driver,
                TimeSpan.FromSeconds(60)
            );

            wait.Until(d =>
                d.FindElements(
                    By.XPath("//input[@name='username']")
                ).Count > 0
            );

            Console.WriteLine("OrangeHRM login page opened.");

            WaitForTest(3);
        }

        // Pause so you can watch the test
        public void WaitForTest(int seconds = 3)
        {
            Thread.Sleep(seconds * 1000);
        }

        public void TearDown()
        {
            // Keep the browser open after the test.
            // Close Chrome manually when you finish observing.
        }
    }
}
