﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CSE2522_Assignment02.Pages
{
    public class TextInputPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public TextInputPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        IWebElement InputField =>
            wait.Until(d => d.FindElement(By.Id("newButtonName")));

        IWebElement Button =>
            wait.Until(d => d.FindElement(By.Id("updatingButton")));

        public void Open()
        {
            driver.Navigate().GoToUrl("https://uitestingplayground.com/textinput");
        }

        public void EnterText(string text)
        {
            InputField.Clear();
            InputField.SendKeys(text);
        }

        
        public void UpdateButton()
        {
            Button.Click();
        }

        public string GetButtonText()
        {
            return Button.Text;
        }
    }
}