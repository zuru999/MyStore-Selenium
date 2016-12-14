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
            waitOnPage(3);
            txtEmail.Clear();
            txtEmail.EnterText(EmailAdress);
            btnCreateAccount.Click();
        }

        public void waitOnPage(int seconds)                                            //metoda która będzie czekała po załadaowaniu strony określony czas
        {                                                                               //przeliczana z milisekund na sekundy
            System.Threading.Thread.Sleep(seconds * 1000);
        }
    }
}
