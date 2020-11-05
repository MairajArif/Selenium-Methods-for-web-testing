using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Seleniumtest
{
    class SeleniumMethod
    {
        public static void textboxinput(IWebDriver driver,string element,string elementType)
        {
            driver.FindElement(By.Id(element)).SendKeys(elementType);

        }
        public static void click(IWebDriver driver, string element, string elementType)
        {
            driver.FindElement(By.ClassName(element)).Click();
        }

        public static void selectDropDown(IWebDriver driver, string element, string value, string elementType)
        {
            new SelectElement(driver.FindElement(By.ClassName(element))).SelectByText(value);
        }
    }
}
