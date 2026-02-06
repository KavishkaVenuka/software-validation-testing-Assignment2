using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSE2522_Assignment02.Pages
{
    public class AlertsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        private readonly By alertButton = By.Id("alertButton");
        private readonly By confirmButton = By.Id("confirmButton");
        private readonly By promptButton = By.Id("promptButton"); 

        public AlertsPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        
        public void Open()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/alerts");
            wait.Until(d => d.FindElement(alertButton));
        }

        
        public string SimpleAlert()
        {
            driver.FindElement(alertButton).Click();

            IAlert alert = wait.Until(d => d.SwitchTo().Alert());
            string text = alert.Text ?? string.Empty;
            alert.Accept();

            return text;
        }

        
        public string ConfirmYes()
        {
            driver.FindElement(confirmButton).Click();

            IAlert confirm = wait.Until(d => d.SwitchTo().Alert());
            confirm.Accept();

            IAlert result = wait.Until(d => d.SwitchTo().Alert());
            string text = result.Text ?? string.Empty;
            result.Accept();

            return text;
        }

       
        public string ConfirmNo()
        {
            driver.FindElement(confirmButton).Click();

            IAlert confirm = wait.Until(d => d.SwitchTo().Alert());
            confirm.Dismiss();

            IAlert result = wait.Until(d => d.SwitchTo().Alert());
            string text = result.Text ?? string.Empty;
            result.Accept();

            return text;
        }

        
        public string PromptAccept(string input)
        {
            driver.FindElement(promptButton).Click();

            IAlert prompt = wait.Until(d => d.SwitchTo().Alert());
            prompt.SendKeys(input);
            prompt.Accept();

            IAlert result = wait.Until(d => d.SwitchTo().Alert());
            string rawText = result.Text ?? string.Empty;
            result.Accept();

            
            return rawText.Replace("User value:", "user value").Trim();
        }

        
        public string PromptCancel()
        {
            driver.FindElement(promptButton).Click();

            IAlert prompt = wait.Until(d => d.SwitchTo().Alert());
            prompt.Dismiss();

            IAlert result = wait.Until(d => d.SwitchTo().Alert());
            string rawText = result.Text ?? string.Empty;
            result.Accept();

            
            return rawText
                .Replace("User value:", "user value -")
                .Replace("no answer", "No answer")
                .Trim();
        }
    }
}