using OpenQA.Selenium;
using OrangeHRMProject.Sources.Drivers;
using SeleniumExtras.PageObjects;

namespace OrangeHRMProject.Source.Pages
{
    public class DashboardPage : Driver
    {

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement _searchtxtbox { get; set; }

        [FindsBy(How = How.ClassName, Using = "oxd-userdropdown")]
        private IWebElement _dropdownbutton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/web/index.php/auth/logout']")]
        private IWebElement _logoutbutton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/web/index.php/pim/viewPimModule']")]
        private IWebElement _pimbutton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='/web/index.php/admin/viewAdminModule']")]
        private IWebElement _adminbutton { get; set; }

        public DashboardPage()
        {
            PageFactory.InitElements(driver: _driver, page: this);

        }
        public void Search(string searchbox)
        {
            _searchtxtbox.SendKeys(searchbox);
            _searchtxtbox.Click();
        }
        public void LogOoo()
        {
            _dropdownbutton.Click();
            _logoutbutton.Click();
        }
        public void Employee()
        {
            _pimbutton.Click();
        }
        public void Adminn()
        {
            _adminbutton.Click();
        }
    }
}
