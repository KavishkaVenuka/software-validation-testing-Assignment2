using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenSampleApp()
        {
            // Implement navigation to the Sample app page here...
            // driver.Navigate().GoToUrl("http://kavishka-venuka.me");
        }
    }
}