using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSE2522_Assignment02.Pages
{
    public class ClientSideDelayPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ClientSideDelayPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void Open()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/clientdelay");

            
            wait.Until(d => d.FindElement(By.Id("AJAXButton")));
        }

        public void ClickButton()
        {
            IWebElement button = wait.Until(d =>
                d.FindElement(By.Id("AJAXButton"))
            );

            button.Click();
        }

        public string GetResult()
        {
            
            WebDriverWait longWait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            IWebElement result = longWait.Until(d =>
                d.FindElement(By.XPath("//p[contains(text(),'Data calculated')]"))
            );

            return result.Text;
        }
    }
}