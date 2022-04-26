using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.Alerts_Frame_and_Windows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            #region Browser Windows

            Driver.FindElement(By.Id("tabButton")).Click();
            Thread.Sleep(2000);

            string a = Driver.WindowHandles[0];
            string b = Driver.WindowHandles[1];
            Driver.SwitchTo().Window(a);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("windowButton")).Click();
            Thread.Sleep(2000);

            string c = Driver.WindowHandles[0];
            string d = Driver.WindowHandles[2];
            Driver.SwitchTo().Window(c);
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("messageWindowButton")).Click();
            Thread.Sleep(2000);

            string e = Driver.WindowHandles[0];
            string f = Driver.WindowHandles[3];
            Driver.SwitchTo().Window(e);
            Thread.Sleep(2000);
            #endregion

            #region Alerts

            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/alerts");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("alertButton")).Click();
            Thread.Sleep(2000);

            Driver.SwitchTo().Alert().Accept();

            Driver.FindElement(By.Id("confirmButton")).Click();
            Thread.Sleep(2000);

            Driver.SwitchTo().Alert().Accept();

            Driver.FindElement(By.Id("promtButton")).Click();
            Thread.Sleep(2000);

            Driver.SwitchTo().Alert().SendKeys("Mou");
            Thread.Sleep(2000);
            Driver.SwitchTo().Alert().Accept();

            #endregion

            #region Frames

            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);

            Driver.Navigate().GoToUrl("https://demoqa.com/frames");
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,400)");
            Thread.Sleep(2000);
            #endregion

            #region Nested Frames

            Driver.Navigate().GoToUrl("https://demoqa.com/nestedframes");
            Thread.Sleep(2000);

            #endregion

            #region Modal Dialogs

            Driver.Navigate().GoToUrl("https://demoqa.com/modal-dialogs");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("showSmallModal")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[text()='Close']")).Click();

            Driver.FindElement(By.XPath("//button[@id='showLargeModal' and @type='button']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//button[text()='Close']")).Click();

            #endregion

            Console.Write("Test Case Closed:");
            Driver.Close();
            Driver.Quit();
        }
    }
}
