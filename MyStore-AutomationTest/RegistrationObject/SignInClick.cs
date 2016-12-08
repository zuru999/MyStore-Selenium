using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore_AutomationTest.RegistrationObject
{
    class SignInClick
    {
        public SignInClick()
        {
            PageFactory.InitElements(PropertiesToDriver.Driver, this);   
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='header']/div[2]/div/div/nav/div[1]/a")]
        public IWebElement btnSignIn { get; set; }

        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement btnCreateAccount { get; set; }



        public void FillUserSignIn(string EmailAdress)
        {
            btnSignIn.Click();
            txtEmail.EnterText(EmailAdress);
            btnCreateAccount.Click();
        }

    }
}
