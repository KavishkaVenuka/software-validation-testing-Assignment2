﻿using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
    public class TextInputTests : BaseTest
    {
        [Test]
        [Description("Update button text with valid input")]
        public void UpdateButtonText_WithValidInput()
        {
            var page = new TextInputPage(driver, wait);
            page.Open();

            page.EnterText("Test button");
            page.UpdateButton(); 

            Assert.That(page.GetButtonText(), Is.EqualTo("Test button"));
        }
    }
}
    