using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

namespace MyStore_AutomationTest
{

    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE,
        Opera
    }

    [TestFixture]
    public class PropertiesToBrowsers : PropertiesToDriver
    {
        private BrowserType _browserType;

        public PropertiesToBrowsers(BrowserType browser)
        {
            _browserType = browser;

        }


        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
            Driver.Manage().Window.Maximize();
        }



        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
                Driver = new ChromeDriver();
            else if (browserType == BrowserType.Firefox)
                Driver = new FirefoxDriver();
            else if (browserType == BrowserType.IE)
                Driver = new InternetExplorerDriver();
            else if (browserType == BrowserType.Opera)
                Driver = new OperaDriver();
        }
    }
}
