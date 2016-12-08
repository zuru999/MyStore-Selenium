
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.IO;
using MyStore_AutomationTest.RegistrationObject;
using OpenQA.Selenium.Support.UI;
//using Excel;
//using System.Data;

namespace MyStore_AutomationTest
{

    [TestFixture]
    [Parallelizable]
    public class ChromeTest : PropertiesToBrowsers
    {


        public ChromeTest() : base(BrowserType.Chrome)
        {

        }

        [Test]
        public void Chrome_RegistrationTest()
        {
            RegistrationPageObject registrationPage = new RegistrationPageObject();
            SignInClick  SignClickRegistration = new SignInClick();

            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");




            SignClickRegistration.FillUserSignIn("testowyadresemail@test.pl");


            waitingForPageUntilEmeentIsVisible(By.Id("uniform-id_gender1"), 5);

            registrationPage.FillUserForm("Mateusz", "Test", "Qweqwe123", "Mateusz", "Test",
                                          "Hamynha Software", "Hamynha Software", "Strzegomska 103 53-610 Wroclaw", "Wroclaw", "53-610",
                                          "Please send the package imidetley", "746490001", "667224762", "Company Adress");

           




        }

        public void waitingForSite()
        {
            //Driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp/");
            //Driver.FindElement(By.Id("contact_link")).Click();
            //waitOnPage(5);                                                        // wywołanie metody waitingOnPage (podanie w () jak długo strona ma czekać na całą stronę.
            //waitingForPageUntilEmeentIsVisible(By.Id("uniform-id_gender1"), 5); ;           // wywołanie metody waitingForPageUUntil.... w nawiasach podajemy nazwę elementu oraz maxymalny czas oczekiwania                                               
        }

        public void waitOnPage(int seconds)                                             //metoda która będzie czekała po załadaowaniu strony określony czas
        {                                                                               //przeliczana z milisekund na sekundy
            System.Threading.Thread.Sleep(seconds * 1000);
        }

        public IWebElement waitingForPageUntilEmeentIsVisible(By locator, int maxSeconds)    //metoda ktora będzie czekała na stronę do czasu gdy dany element ejst widoczny 
        {                                                                                    //pomaga w redukcji czasu na ozekiwanie obiektu
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(maxSeconds))              // poczekaj 5 sekund do czasu az (excepted conditions) czyli contact likn zostanie znaleziony (elementexist)    
                .Until(ExpectedConditions.ElementExists((locator)));                         //jesli go znajdziesz, pokaz mi go antychmiast, nie czekaj maxylamnego czasu oczekiwania   
        }
    }
}
