using OpenQA.Selenium;

namespace UnitTestEbay
{
    class SeleniumSetMethods
    {
        public static void EnterText(IWebDriver driver, string element, string value, string type)
        {

            if (type == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (type == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }

        }
        
        public static void Click(IWebDriver driver, string element, string type)
        {
            if (type == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (type == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
            if (type == "LinkText")
            {
                driver.FindElement(By.LinkText(element)).Click();
            }
            if (type == "ClassName")
            {
                driver.FindElement(By.LinkText(element)).Click();
            }
        }

        }
    }

