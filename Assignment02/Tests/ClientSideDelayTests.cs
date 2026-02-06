using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
    public class ClientSideDelayTests : BaseTest
    {
        [Test]
        public void VerifyContentLoadsAfterDelay()
        {
            var page = new ClientSideDelayPage(driver);

            page.Open();        
            page.ClickButton(); 

            Assert.That(page.GetResult(), Does.Contain("Data calculated"));
        }
    }
}