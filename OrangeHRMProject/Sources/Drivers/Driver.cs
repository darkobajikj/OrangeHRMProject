using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace OrangeHRMProject.Sources.Drivers
{
    public class Driver
    {
        [ThreadStatic]
        public static IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
