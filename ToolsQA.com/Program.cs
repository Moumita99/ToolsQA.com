using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");
            string name = "Moumita Halder";
            string email = "moumita.halder1999@gmail.com";
            string Cadd = "Kolkata";
            string Padd = "Kolkata";

            int n = 22;
            string age;
            age = n.ToString();

            int s = 20000;
            string salary;
            salary = s.ToString();



            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //Text Box

            Driver.FindElement(By.Id("item-0")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("userName")).SendKeys(name);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("userEmail")).SendKeys(email);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("currentAddress")).SendKeys(Cadd);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("permanentAddress")).SendKeys(Padd);
            Thread.Sleep(2000);


            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("submit")).Click();
            Thread.Sleep(2000);

            //Check Box

            js.ExecuteScript("window.scrollBy(500,0)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("item-1")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@class='rct-collapse rct-collapse-btn']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@class='rct-collapse rct-collapse-btn']")).Click();
            Thread.Sleep(2000);

            //Radio Button

            Driver.FindElement(By.Id("item-2")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.ClassName("custom-control-label")).Click();
            Thread.Sleep(2000);

            //Web Tables

            Driver.FindElement(By.Id("item-3")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("addNewRecordButton")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("firstName")).SendKeys("Moumita");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("lastName")).SendKeys("Halder");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("userEmail")).SendKeys("moumita.halder1999@gmail.com");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("age")).SendKeys(age);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("salary")).SendKeys(salary);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("department")).SendKeys("ECE");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("submit")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='First Name']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Last Name']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Age']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Email']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Salary']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Department']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Moumita");
            Thread.Sleep(2000);

            //Button

            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("item-4")).Click();
            Thread.Sleep(2000);

            Actions action = new Actions(Driver);

            action.MoveToElement(Driver.FindElement(By.XPath("//button[@id='doubleClickBtn']"))).DoubleClick().Build().Perform();
            Thread.Sleep(2000);

            action.MoveToElement(Driver.FindElement(By.XPath("//button[@id='rightClickBtn']"))).ContextClick().Build().Perform();
            Thread.Sleep(2000);

            //Links

            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("item-5")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[contains(@href,'https://demoqa.com')]")).Click();
            Thread.Sleep(5000);

            Driver.Navigate().GoToUrl("https://demoqa.com/links");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("dynamicLink")).Click();
            Thread.Sleep(5000);

            string a = Driver.WindowHandles[0];
            string b = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(a);
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("created")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("no-content")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("moved")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("bad-request")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("unauthorized")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("forbidden")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("invalid-url")).Click();
            Thread.Sleep(2000);

            //Broken Links - Images

            Driver.FindElement(By.Id("item-6")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[contains(@href,'http://the-internet.herokuapp.com/status_codes/500')]")).Click();
            Thread.Sleep(3000);

            Driver.Navigate().Back();
            Thread.Sleep(2000);

            //Upload and Document

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("item-7")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("downloadButton")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("uploadFile")).SendKeys("D:\\20160501_172802.jpg");
            Thread.Sleep(2000);

            //Dynamic Properties

            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("item-8")).Click();
            Thread.Sleep(6000);

            Console.Write("Test Case Closed:");
            Driver.Close();
            Driver.Quit();
        }
    }
}
