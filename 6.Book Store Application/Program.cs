using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6.Book_Store_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/login");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@type='text' and @id='userName']")).SendKeys("mh@12");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@type='password' and @id='password']")).SendKeys("Mh@12345");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@type='button' and @id='login']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@type='button' and @id='gotoStore']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Image']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Title']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Author']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='rt-resizable-header-content'][text()='Publisher']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@id='searchBox']")).SendKeys("Speaking");
            Thread.Sleep(2000);

            Console.Write("Test Case Closed:");
            Driver.Close();
            Driver.Quit();
        }
    }
}
