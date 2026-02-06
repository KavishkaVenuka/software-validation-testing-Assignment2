using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CSE2522_Assignment02.Pages
{
    public class SampleAppPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public SampleAppPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

      
        private IWebElement Username =>
            wait.Until(d => d.FindElement(By.Name("UserName")));

        private IWebElement Password =>
            wait.Until(d => d.FindElement(By.Name("Password")));

        private IWebElement LoginButton =>
            wait.Until(d => d.FindElement(By.Id("login")));

        private IWebElement StatusMessage =>
            wait.Until(d => d.FindElement(By.Id("loginstatus")));

        
        public void Open()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/sampleapp");
        }

        
        public bool IsPageLoaded()
        {
            return Username.Displayed
                && Password.Displayed
                && LoginButton.Displayed;
        }

        
        public void Login(string username, string password)
        {
            Username.Clear();
            Username.SendKeys(username);

            Password.Clear();
            Password.SendKeys(password);

            LoginButton.Click();
        }

        
        public string GetStatus()
        {
            return StatusMessage.Text;
        }
    }
}