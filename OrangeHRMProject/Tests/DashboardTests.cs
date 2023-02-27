using OpenQA.Selenium;
using OrangeHRMProject.Source.Pages;
using OrangeHRMProject.Sources.Drivers;
using Assert = NUnit.Framework.Assert;


namespace OrangeHRMProject.Tests
{
    public class DashboardTests : Driver
    {

        [Test]
        public void Searches()
        {
            DashboardPage dp = new DashboardPage();
            _driver.Navigate().GoToUrl(" https://opensource-demo.orangehrmlive.com/web/index.php/auth/login ");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(8000);
            HomePage hp = new HomePage();
            hp.Login(user: "Admin", password: "admin123");
            Thread.Sleep(8000);
            dp.Search("Time");
            Thread.Sleep(8000);
            Assert.AreEqual("Time", _driver.FindElement(By.CssSelector("span")).Text);
        }
        [Test]
        public void LogOut()
        {
            DashboardPage dp = new DashboardPage();
            _driver.Navigate().GoToUrl(" https://opensource-demo.orangehrmlive.com/web/index.php/auth/login ");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            HomePage hp = new HomePage();
            hp.Login(user: "Admin", password: "admin123");
            Thread.Sleep(4000);
            dp.LogOoo();
            Thread.Sleep(6000);
            Assert.IsTrue(_driver.FindElement(By.Name("username")).Displayed);
        }
        [Test]
        public void SearchEmployee()
        {
            DashboardPage dp = new DashboardPage();
            _driver.Navigate().GoToUrl(" https://opensource-demo.orangehrmlive.com/web/index.php/auth/login ");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            HomePage hp = new HomePage();
            hp.Login(user: "Admin", password: "admin123");
            Thread.Sleep(4000);
            dp.Employee();
            Thread.Sleep(4000);
            PimPage pm = new PimPage();
            pm.EmployeeSearch(username: "Alice Duval");
            Thread.Sleep(6000);
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@role='rowgroup']")).Displayed);
        }
        [Test]
        public void AddUsers()
        {
            DashboardPage dp = new DashboardPage();
            _driver.Navigate().GoToUrl(" https://opensource-demo.orangehrmlive.com/web/index.php/auth/login ");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(4000);
            HomePage hp = new HomePage();
            hp.Login(user: "Admin", password: "admin123");
            Thread.Sleep(4000);
            dp.Adminn();
            Thread.Sleep(4000);
            AdminPage ap = new AdminPage();
            ap.AddUser();
            Thread.Sleep(4000);
            Assert.True(_driver.FindElement(By.CssSelector("div > h6")).Text.Contains("Add User"));


        }
    }
}
