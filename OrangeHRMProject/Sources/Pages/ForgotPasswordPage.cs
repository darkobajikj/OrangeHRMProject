using OpenQA.Selenium;
using OrangeHRMProject.Sources.Drivers;
using SeleniumExtras.PageObjects;

namespace OrangeHRMProject.Source.Pages
{
    public class ForgotPasswordPage : Driver
    {

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Username']")]
        private IWebElement _forgotinput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[2][@type='submit']")]
        private IWebElement _resetbutton { get; set; }

        public ForgotPasswordPage()
        {
            PageFactory.InitElements(driver: _driver, page: this);

        }
        public void ForgetPass(string forg)
        {
            _forgotinput.SendKeys(forg);
            _resetbutton.Click();
        }
    }
}
