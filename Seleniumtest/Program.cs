using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seleniumtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program call = new Program();

            call.initilize();
            call.loginTestCases();
            //call.profileEdit();
            //call.ChangePassword();
            //call.dashboard();
            // SeleniumMethod.selectDropDown(call.driver, "dropdownBasic3", "Admin User","Id");
            // SeleniumMethod.textboxinput(call.driver,"",)
            //call.logout();
            call.challengeDescription();
            //call.viewTransaction();
            //call.AddCategeory();
           // call.close();
        }

        //create reference of our web
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void initilize()
        {
            //navigate to url page
            driver.Navigate().GoToUrl("https://ichallengeyou.mtpixels.com/login");
            Console.WriteLine("Open URL");

        }
      
        [Test]
        public void loginTestCases()
        {
            //find input element
            IWebElement element = driver.FindElement(By.Name("username"));

            //Perform action or input
            element.SendKeys("admin");

            //find input element
            element = driver.FindElement(By.Name("password"));

            //Perform action or input
            element.SendKeys("secret");
            driver.FindElement(By.TagName("button")).Click();
            Console.WriteLine("login successfully");
        }
        [Test]
        public void loginTestCases1()
        {
            //find input element
            IWebElement element = driver.FindElement(By.Name("username"));

            //Perform action or input
            element.SendKeys("a");

            //find input element
            element = driver.FindElement(By.Name("password"));

            //Perform action or input
            element.SendKeys("secret");
            driver.FindElement(By.TagName("button")).Click();
            Console.WriteLine(" InValid login ");
        }
        [Test]
        public void dashboard()
        {
            driver.FindElement(By.ClassName("icon-home")).Click();
            Console.WriteLine("Click home icon");
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("ft-activity")).Click();
            Console.WriteLine("Click challenge icon");
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("icon-wallet")).Click();
            Console.WriteLine("Click Transactions icon");
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("icon-users")).Click();
            Console.WriteLine("Click Users icon");
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("icon-grid")).Click();
            Console.WriteLine("Click Category icon");
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("icon-bell")).Click();
            Console.WriteLine("Click Notification icon");
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("icon-speech")).Click();
            Console.WriteLine("Click Custom Message icon");
            Thread.Sleep(2000);

            driver.FindElement(By.ClassName("icon-wrench")).Click();
            Console.WriteLine("Click Setting icon");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("dropdownBasic2")).Click();
            Console.WriteLine("Show notification in drop down list ");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("dropdownBasic2")).Click();
            Console.WriteLine("Close drop down notification");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("dropdownBasic3")).Click();
            Console.WriteLine("Show personal Information in drop down list");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("dropdownBasic3")).Click();
            Console.WriteLine("Close personal Information");
            Thread.Sleep(2000);
        }
        [Test]
        public void profileEdit()
        {
            driver.FindElement(By.Id("dropdownBasic3")).Click();
            driver.FindElement(By.ClassName("icon-user")).Click();
            driver.FindElement(By.Id("name")).Clear();
            Thread.Sleep(2000);
            SeleniumMethod.textboxinput(driver, "name", "Admin User");
            SeleniumMethod.click(driver, "icon-note", "Id");
            Console.WriteLine("Profile Update successfully");
        }
        [Test]
        public void ChangePassword()
        {
            driver.FindElement(By.Id("dropdownBasic3")).Click();
            driver.FindElement(By.ClassName("ft-lock")).Click();
            SeleniumMethod.textboxinput(driver, "old_password", "secret");
            Thread.Sleep(1000);
            SeleniumMethod.textboxinput(driver, "password", "secret");
            Thread.Sleep(1000);
            SeleniumMethod.textboxinput(driver, "password_confirmation", "secret");
            Thread.Sleep(1000);
            SeleniumMethod.click(driver, "icon-note", "Id");
            Console.WriteLine("Password Update successfully");
        }

        [TearDown]
        public void close()
        {
            driver.Close();
            Console.WriteLine("screen close");
        }
        
        [Test]
        public void logout()
        {
            driver.FindElement(By.Id("dropdownBasic3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ft-power")).Click();
            Console.WriteLine("Logout Successfully");
        }
        [Test]
        public void challengeDescription()
        {
            driver.FindElement(By.ClassName("ft-activity")).Click();
            Console.WriteLine("Click challenge icon");
            Thread.Sleep(2000);
            // var eyes = driver.FindElements(By.ClassName("ft-eye"));
            // var hrefs = driver.FindElements(By.ClassName("ft-eye")).Select(x => x.GetProperty("href"));
            //var link = driver.FindElements(By.TagName("a")).Count();
            var item = driver.FindElements(By.TagName("a"));
            // driver.FindElements(By.TagName("a")).ToList()[1].GetAttribute("href");

            for (int i = 0; i < item.Count(); i++)
            {
                //driver.FindElements(By.TagName("a")).ToList()[i].GetAttribute("href");
                Console.WriteLine(" " + driver.FindElements(By.TagName("a")).ToList()[i].GetAttribute("href"));
            }
        }

        // ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");

        /*  IWebElement htmltable = driver.FindElement(By.Id("dTable"));
          List<IWebElement> rows = htmltable.FindElements(By.tagName("tr"));

        /*  foreach (var i in item)
          {
              var j = driver.FindElements(By.TagName("href")).ToList()[i].GetAttribute("href");
              var k = driver.FindElements(By.TagName("a")).ToList()[i].GetAttribute("href");
              //item.Click();
              Console.WriteLine("Iteration number"+j);
             // driver.Navigate().Back();
              //Thread.Sleep(20000);
              //driver.Navigate().Refresh();
              //Thread.Sleep(20000);
          }

        

         // driver.FindElements(By.TagName("a")).ToList()[2].GetAttribute("href") 
           //   "https://ichallengeyou.mtpixels.com/dashboard"  string

      }
      */
        public void viewTransaction()
        {
            driver.FindElement(By.ClassName("icon-wallet")).Click();
            Console.WriteLine("Click Transactions icon");
            Thread.Sleep(2000);
            
        }
        [Test]
        public void AddCategeory()
        {
            driver.FindElement(By.ClassName("icon-grid")).Click();
            Console.WriteLine("Click Category icon");
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.Id("name"));
            element.SendKeys("abc");
            Console.WriteLine("Add category");
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("btn-danger")).Click();
            element.SendKeys("");
            Thread.Sleep(2000);
            element.SendKeys("abc");
            driver.FindElement(By.ClassName("btn-success")).Click();
            driver.FindElement(By.ClassName("swal2-confirm")).Click();

        }
    }
}
