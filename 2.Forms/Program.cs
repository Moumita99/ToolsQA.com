using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Forms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            long n = 7003381098;
            string num;
            num = n.ToString();

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("firstName")).SendKeys("Moumita");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("lastName")).SendKeys("Halder");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("userEmail")).SendKeys("moumita.halder1999@gmail.com");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//label[text()='Female']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("userNumber")).SendKeys(num);
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//label[text()='Reading']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("uploadPicture")).SendKeys("D:\\20160501_172802.jpg");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("currentAddress")).SendKeys("Kolkata");
            Thread.Sleep(2000);

            Console.Write("Test Case Closed:");
            Driver.Close();
            Driver.Quit();
        }
    }
}
