﻿using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CSE2522_Assignment02.Tests
{
    public class AlertsTests : BaseTest
    {
        // TC004-[1]
        [Test]
        public void VerifyAlertsPage()
        {
            var page = new AlertsPage(driver, wait);
            page.Open();

            Assert.That(driver.FindElement(By.Id("alertButton")).Displayed);
            Assert.That(driver.FindElement(By.Id("confirmButton")).Displayed);
            Assert.That(driver.FindElement(By.Id("promptButton")).Displayed);
        }

        // TC004-[2]
        [Test]
        public void VerifySimpleAlertText()
        {
            var page = new AlertsPage(driver, wait);
            page.Open();

            string text = page.SimpleAlert();

            Assert.That(text, Does.Contain("Today is a working day"));
        }

        // TC004-[3 confirm alert - yes]
        [Test]
        public void VerifyConfirmAlertYes()
        {
            var page = new AlertsPage(driver, wait);
            page.Open();

            string result = page.ConfirmYes();

            Assert.That(result, Is.EqualTo("Yes"));
        }

        // TC004-[3 confirm alert - no]
        [Test]
        public void VerifyConfirmAlertNo()
        {
            var page = new AlertsPage(driver, wait);
            page.Open();

            string result = page.ConfirmNo();

            Assert.That(result, Is.EqualTo("No"));
        }

        // TC004-[4 prompt accept]
        [Test]
        public void VerifyPromptAccept()
        {
            var page = new AlertsPage(driver, wait);
            page.Open();

            string result = page.PromptAccept("Lasal");

            Assert.That(result, Is.EqualTo("user value : Lasal"));
        }

        // TC004-[4 prompt cancel]
        [Test]
        public void VerifyPromptCancel()
        {
            var page = new AlertsPage(driver, wait);
            page.Open();

            string result = page.PromptCancel();

            Assert.That(result, Is.EqualTo("user value - No answer"));
        }
    }
}