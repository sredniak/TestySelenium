using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestEbay
{

    class GoogleChrome
    {
        IWebDriver driver = new ChromeDriver();

        public static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.ebay.pl/");
            Console.WriteLine("Strona została otwarta");
        }
        [Test]
        public void Sprzedaj()
        {
            SeleniumSetMethods.Click(driver, "Sprzedaj", "LinkText");
            SeleniumSetMethods.EnterText(driver, "smac_complete", "Buty rozmiar 45", "Name");

            Console.WriteLine("Otworzono zakładkę Sprzedaj i wpisano wartość w pole tekstowe");
        }
        [Test]
        public void MaksymalizacjaOknaPrzegladarki()
        {
            driver.Manage().Window.Maximize();
            Console.WriteLine("Zmaksymalizowano okno przeglądarki");
        }
        [Test]
        public void WpisywanieWartosciDoPolaWyszukaj()
        {
           
            SeleniumSetMethods.EnterText(driver, "gh-ac", "iphone", "Id");

            SeleniumSetMethods.Click(driver, "gh-btn", "Id");

            SeleniumSetMethods.EnterText(driver, "e1-13", "100", "Id");
            SeleniumSetMethods.EnterText(driver, "e1-14", "500", "Id");
            SeleniumSetMethods.Click(driver, "e1-61", "Id");

            Console.WriteLine("Wpisano wyszukiwaną wartość do pola wyszukaj ustalono cenę od 100 do 500");
        }
        [Test]
        public void ZakladkaZaloguj()
        {
            SeleniumSetMethods.Click(driver, "Zaloguj się", "LinkText");
        
            Console.WriteLine("Otworzono zakładkę Zaloguj się");

        }
        [Test]
        public void InformacjeOSerwisie()
        {
            SeleniumSetMethods.Click(driver, "O serwisie eBay", "LinkText");

            Console.WriteLine("Otworzono zakładkę O serwisie eBay");

        }
        [Test]
        public void PokazKategorie()
        {
            SeleniumSetMethods.Click(driver, "gh-shop-ei", "Id");
            
            Console.WriteLine("Rozwinięto listę kategorii produktów");

        }
        [Test]
        public void SzukanieZaawansowane()
        {
            SeleniumSetMethods.Click(driver, "Zaawansowane", "LinkText");
            SeleniumSetMethods.EnterText(driver, "_nkw", "iphone 5s", "Id");
            SeleniumSetMethods.Click(driver, "LH_TitleDesc", "Id");
            SeleniumSetMethods.Click(driver, "_mPrRngCbx", "Id");
            SeleniumSetMethods.EnterText(driver, "_udlo", "50", "Name");
            SeleniumSetMethods.EnterText(driver, "_udhi", "459", "Name");



            Console.WriteLine("Szukanie zaawansowane -> ustawienie wartości");

        }
        [TearDown]
        public void CleanUp()
        {
            //driver.Quit();
            Console.WriteLine("Zamknięcie przegladarki");
        }
    }
        
}

