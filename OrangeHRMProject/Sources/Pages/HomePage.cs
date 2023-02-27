using OpenQA.Selenium;
using OrangeHRMProject.Sources.Drivers;
using SeleniumExtras.PageObjects;

namespace OrangeHRMProject.Source.Pages
{
    public class HomePage : Driver
    {
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement _usernameinput { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement _passwordinput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div > button[type='submit']")]
        private IWebElement _submitbutton { get; set; }

        [FindsBy(How = How.ClassName, Using = "orangehrm-login-forgot")]
        private IWebElement _forgotbutton { get; set; }

        public HomePage()
        {

            PageFactory.InitElements(driver: _driver, page: this);

        }
        public void Login(string user, string password)
        {
            _usernameinput.SendKeys(text: user);
            _passwordinput.SendKeys(text: password);
            _submitbutton.Click();
        }
        public void Forgot()
        {
            _forgotbutton.Click();
        }
    }
}
