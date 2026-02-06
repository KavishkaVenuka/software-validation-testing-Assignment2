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
            driver.Navigate().GoToUrl("https://uitestingplayground.com/sampleapp");
        }
    }
}