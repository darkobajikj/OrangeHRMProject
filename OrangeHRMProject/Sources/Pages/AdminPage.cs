using OpenQA.Selenium;
using OrangeHRMProject.Sources.Drivers;
using SeleniumExtras.PageObjects;

namespace OrangeHRMProject.Source.Pages
{
    public class AdminPage : Driver
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[1]/div[2]/div[2]/div/div[2]/div[1]/button")]
        private IWebElement _adduserbuttonn { get; set; }

        public AdminPage()
        {
            PageFactory.InitElements(driver: _driver, page: this);
        }
        public void AddUser()
        {
            _adduserbuttonn.Click();
        }
    }
}
