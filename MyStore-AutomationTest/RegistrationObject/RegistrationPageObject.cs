using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;



namespace MyStore_AutomationTest.RegistrationObject
{
    class RegistrationPageObject
    {

        public RegistrationPageObject()
        {
            PageFactory.InitElements(PropertiesToDriver.Driver, this);
        }


      

        [FindsBy(How = How.Id, Using = "uniform-id_gender1")]
        public IWebElement btnGender { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "days")]
        public IWebElement dropdownDays { get; set; }

        [FindsBy(How = How.Id, Using = "months")]
        public IWebElement dropdownMonths { get; set; }

        [FindsBy(How = How.Id, Using = "years")]
        public IWebElement dropdownYears { get; set; }

        [FindsBy(How = How.Id, Using = "newsletter")]
        public IWebElement checkboxNews { get; set; }

        [FindsBy(How = How.Id, Using = "optin")]
        public IWebElement checboxOffers { get; set; }

        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement txtAddressFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "years")]
        public IWebElement txtAddressLastName { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        public IWebElement txtCompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement txtAdress1 { get; set; }

        [FindsBy(How = How.Id, Using = "address2")]
        public IWebElement txtAdress2 { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement txtCity { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement dropdownStateDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement txtZpiPostCode { get; set; }

        [FindsBy(How = How.Id, Using = "id_country")]
        public IWebElement dropdowndCountry { get; set; }

        [FindsBy(How = How.Id, Using = "other")]
        public IWebElement txtAdditionalInfo { get; set; }

        [FindsBy(How = How.Id, Using = "phone")]
        public IWebElement txtLandLineNumber { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement txtMobilephone { get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement txtAllias { get; set; }







        public void FillUserForm(string firstName, string lastName, string typePassword, string addresFirstName,
                                 string addresLastName, string companyName, string companyAdress1, string companyAdress2, string cityName,
                                 string zipPostCode, string additionalInfo, string landLinePhone, string mobilePhone, string allias )       
                                 // moze byc void bo nie zwraca nam potem zadnego obiektu
        {

            
            
            //System.Threading.Thread.Sleep(2000);
            btnGender.Click();
            txtFirstName.EnterText(firstName);
            txtLastName.EnterText(lastName);
            //Assert.AreEqual(txtEmail, EmailAdress);
            txtPassword.EnterText(typePassword);
            dropdownDays.SelectDropDown("24  ");
            dropdownMonths.SelectDropDown("June ");
            dropdownYears.SelectDropDown("1992  ");
            checkboxNews.Click();
            checboxOffers.Click();
            txtAddressFirstName.EnterText(addresFirstName);
            txtAddressLastName.EnterText(addresLastName);
            txtCompanyName.EnterText(companyName);
            txtAdress1.EnterText(companyAdress1);
            txtAdress2.EnterText(companyAdress2);
            txtCity.EnterText(cityName);
            dropdownStateDropdown.SelectDropDown("New York");
            txtZpiPostCode.EnterText(zipPostCode);
            dropdowndCountry.SelectDropDown("United States");
            txtAdditionalInfo.EnterText(additionalInfo);
            txtLandLineNumber.EnterText(landLinePhone);
            txtMobilephone.EnterText(mobilePhone);
            txtAllias.Clear();
            txtAllias.EnterText(allias);
            

        }

        
    }
}
