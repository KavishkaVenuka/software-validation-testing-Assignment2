using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
    public class SampleAppTests : BaseTest
    {
        // TC002-[1] – Page verification
        [Test]
        [Description("TC002-[1] - Sample app page verification")]
        public void VerifySampleAppPage()
        {
            var page = new SampleAppPage(driver, wait);
            page.Open();

            Assert.That(page.IsPageLoaded(), Is.True);
        }

        // TC002-[2] – Successful login
        [Test]
        [Description("TC002-[2] - Successful login")]
        public void VerifySuccessfulLogin()
        {
            var page = new SampleAppPage(driver, wait);
            page.Open();
            page.Login("test", "pwd");

            Assert.That(page.GetStatus(), Does.Contain("Welcome"));
        }

        // TC002-[3] – Unsuccessful login
        [Test]
        [Description("TC002-[3] - Unsuccessful login")]
        public void VerifyUnsuccessfulLogin()
        {
            var page = new SampleAppPage(driver, wait);
            page.Open();
            page.Login("test", "wrong");

            Assert.That(page.GetStatus(), Does.Contain("Invalid"));
        }
    }
}