using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5.Interactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Thread.Sleep(2000);

            //Sortable

            Driver.Navigate().GoToUrl("https://demoqa.com/sortable");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,250)");
            Thread.Sleep(10000);

            Actions action = new Actions(Driver);

            action.ClickAndHold(Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//child::div[1]"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//child::div[4]"))).Release().Build().Perform();
            Thread.Sleep(2000);

            action.ClickAndHold(Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//child::div[2]"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//child::div[6]"))).Release().Build().Perform();
            Thread.Sleep(2000);

            action.ClickAndHold(Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//child::div[4]"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//child::div[1]"))).Release().Build().Perform();
            Thread.Sleep(2000);

            action.ClickAndHold(Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//child::div[3]"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='vertical-list-container mt-4']//child::div[3]"))).Release().Build().Perform();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            Thread.Sleep(2000);

            Actions action1 = new Actions(Driver);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(5000);

            action1.ClickAndHold(Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Five']"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='One']"))).Release().Build().Perform();
            Thread.Sleep(2000);

            action1.ClickAndHold(Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Two']"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='create-grid']//div[text()='Six']"))).Release().Build().Perform();
            Thread.Sleep(2000);

            //Selectable

            Driver.Navigate().GoToUrl("https://demoqa.com/selectable");
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4 list-group']//li[text()='Cras justo odio']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4 list-group']//li[text()='Morbi leo risus']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='demo-tab-grid']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='row1']//li[text()='One']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='row1']//li[text()='Three']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='row2']//li[text()='Five']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='row3']//li[text()='Seven']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@id='row3']//li[text()='Nine']")).Click();
            Thread.Sleep(2000);

            //Droppable

            Driver.Navigate().GoToUrl("https://demoqa.com/droppable");
            Thread.Sleep(2000);

            Actions action2 = new Actions(Driver);

            action2.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='draggable']"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='simple-drop-container']//div[@id='droppable']"))).Release().Build().Perform();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-accept']")).Click();
            Thread.Sleep(2000);

            Actions action3 = new Actions(Driver);

            action3.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='acceptable']"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='accept-drop-container']//div[@id='droppable']"))).Release().Build().Perform();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-preventPropogation']")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            Actions action4 = new Actions(Driver);

            action4.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).MoveToElement(Driver.FindElement(By.XPath("//div[@id='notGreedyInnerDropBox']"))).Release().Build().Perform();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@id='droppableExample-tab-revertable']")).Click();
            Thread.Sleep(2000);

            Actions action5 = new Actions(Driver);

            action5.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='notRevertable']"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='revertable-drop-container']//div[@id='droppable']"))).Release().Build().Perform();
            Thread.Sleep(2000);

            action5.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='revertable']"))).MoveToElement(Driver.FindElement(By.XPath("//div[@class='revertable-drop-container']//div[@id='droppable']"))).Release().Build().Perform();
            Thread.Sleep(2000);

            Console.Write("Test Case Closed:");
            Driver.Close();
            Driver.Quit();
        }
    }
}
