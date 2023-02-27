using OpenQA.Selenium;
using OrangeHRMProject.Sources.Drivers;
using SeleniumExtras.PageObjects;

namespace OrangeHRMProject.Source.Pages
{
    public class PimPage : Driver
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/div/div/input")]
        private IWebElement _employeenameinput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")]
        private IWebElement _employesearchbutton { get; set; }

        public PimPage()
        {
            PageFactory.InitElements(driver: _driver, page: this);
        }
        public void EmployeeSearch(string username)
        {
            _employeenameinput.SendKeys(text: username);
            _employesearchbutton.Click();
        }
    }
}