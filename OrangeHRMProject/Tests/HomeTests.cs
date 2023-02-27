using OpenQA.Selenium;
using OrangeHRMProject.Source.Pages;
using OrangeHRMProject.Sources.Drivers;
using Assert = NUnit.Framework.Assert;


namespace OrangeHRMProject.Tests
{
    [Parallelizable(ParallelScope.All)]
    public class HomeTests : Driver
    {

        [Test]
        public void LogIn()
        {
            HomePage hp = new HomePage();
            _driver.Navigate().GoToUrl(" https://opensource-demo.orangehrmlive.com/web/index.php/auth/login ");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(6000);
            hp.Login(user: "Admin", password: "admin123");
            Thread.Sleep(6000);
            Assert.AreEqual("Dashboard", _driver.FindElement(By.CssSelector("span > h6")).Text);
        }
        [Test]
        public void LogInFake()
        {
            HomePage hp = new HomePage();
            _driver.Navigate().GoToUrl(" https://opensource-demo.orangehrmlive.com/web/index.php/auth/login ");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(6000);
            hp.Login(user: "John", password: "admin123");
            Thread.Sleep(6000);
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@role='alert']")).Displayed);
        }

        [Test]
        public void ForgotPasswordLink()
        {
            HomePage hp = new HomePage();
            _driver.Navigate().GoToUrl(" https://opensource-demo.orangehrmlive.com/web/index.php/auth/login ");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(6000);
            hp.Forgot();
            Thread.Sleep(6000);
            Assert.True(_driver.FindElement(By.CssSelector("div > form > h6")).Text.Contains("Reset Password"));

        }

        [Test]
        public void ForgotPassword()
        {
            HomePage hp = new HomePage();
            _driver.Navigate().GoToUrl(" https://opensource-demo.orangehrmlive.com/web/index.php/auth/login ");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(6000);
            hp.Forgot();
            Thread.Sleep(6000);
            ForgotPasswordPage fp = new ForgotPasswordPage();
            fp.ForgetPass(forg: "Admin");
            Thread.Sleep(6000);
            Assert.AreEqual("Reset Password link sent successfully", _driver.FindElement(By.CssSelector("div > h6")).Text);
        }
    }
}
