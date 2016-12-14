using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore_AutomationTest.RegistrationObject;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using MyStore_AutomationTest.Test;
using Excel;
using System.IO;


namespace MyStore_AutomationTest.Test
{

    [TestFixture]
    [Parallelizable]
    public class FirefoxTest : PropertiesToBrowsers
    {
        public FirefoxTest() : base(BrowserType.Firefox)
        {

        }


        [Test]
        public void Firefox_RegistrationTest()
        {

            SignInClick SignClickRegistration = new SignInClick();
            RegistrationPageObject registrationPage = new RegistrationPageObject();

            ExcelLib.PopulateInCollection(@"C:\C#\Automatyzacja\ExcellData\Employees.xlsx");

            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Console.WriteLine("Udaje pod wskazany adres");
            //waitOnPage(10);
            SignClickRegistration.FillUserSignIn("testowymaill@mailtestowy.pl");
            
            waitOnPage(5);

            registrationPage.FillUserForm(ExcelLib.ReadData(4, "firstName"), ExcelLib.ReadData(4, "lastName"), ExcelLib.ReadData(4, "typePassword"), 
                                   ExcelLib.ReadData(4, "addresFirstName"), ExcelLib.ReadData(4, "addresLastName"), ExcelLib.ReadData(4, "companyName"),
                                   ExcelLib.ReadData(4, "companyAdress1"), ExcelLib.ReadData(4, "companyAdress2"), ExcelLib.ReadData(4, "cityName"),
                                   ExcelLib.ReadData(4, "zipPostCode"), ExcelLib.ReadData(4, "additionalInfo"), ExcelLib.ReadData(4, "landLinePhone"),
                                   ExcelLib.ReadData(4, "mobilePhone"), ExcelLib.ReadData(4, "allias"));

        }
       
        public void waitOnPage(int seconds)                                            //metoda która będzie czekała po załadaowaniu strony określony czas
        {                                                                               //przeliczana z milisekund na sekundy,
            System.Threading.Thread.Sleep(seconds * 1000);
        }
    }
}
