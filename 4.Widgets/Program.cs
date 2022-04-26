using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.Widgets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Case Started:");

            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Thread.Sleep(2000);

            #region Accordian

            Driver.Navigate().GoToUrl("https://demoqa.com/accordian");
            Thread.Sleep(2000);

            Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,300)");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("section2Heading")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("section3Heading")).Click();
            Thread.Sleep(2000);

            #endregion

            #region Date Picker

            Driver.Navigate().GoToUrl("https://demoqa.com/date-picker");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("datePickerMonthYearInput")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@type='button' and @class='react-datepicker__navigation react-datepicker__navigation--previous' ]")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//button[@type='button' and @class='react-datepicker__navigation react-datepicker__navigation--previous' ]")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--023']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//input[@type='text' and @id='dateAndTimePickerInput']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[@class='react-datepicker__month-read-view--down-arrow']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='react-datepicker__month-option'][text()='January']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//span[@class='react-datepicker__year-read-view--down-arrow']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='react-datepicker__year-option'][text()='2024']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--002']")).Click();
            Thread.Sleep(2000);

            #endregion

            #region Slider

            //Driver.Navigate().GoToUrl("https://demoqa.com/slider");
            //Thread.Sleep(2000);

            //WebElement slider = (WebElement)Driver.FindElement(By.XPath("//div[@class='range-slider__tooltip__arrow']"));

            //Actions action = new Actions(Driver);


            //action.DragAndDrop(3,86).Build().Perform();

            #endregion

            #region Progress Bar

            Driver.Navigate().GoToUrl("https://demoqa.com/progress-bar");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("startStopButton")).Click();
            Thread.Sleep(12000);

            Driver.FindElement(By.Id("resetButton")).Click();
            Thread.Sleep(2000);

            #endregion

            #region Tabs

            Driver.Navigate().GoToUrl("https://demoqa.com/tabs");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("demo-tab-what")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("demo-tab-origin")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("demo-tab-use")).Click();
            Thread.Sleep(2000);

            #endregion

            #region Tool Tips

            Driver.Navigate().GoToUrl("https://demoqa.com/tool-tips");
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("toolTipButton")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.Id("toolTipTextField")).Click();
            Thread.Sleep(2000);

            #endregion

            #region Menu

            Driver.Navigate().GoToUrl("https://demoqa.com/menu#");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@href='#'][text()='Main Item 1']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@href='#'][text()='Main Item 2']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//a[@href='#'][text()='Main Item 3']")).Click();
            Thread.Sleep(2000);

            #endregion

            #region Select Menu

            Driver.Navigate().GoToUrl("https://demoqa.com/select-menu");
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div[@class=' css-tlfecz-indicatorContainer']")).Click();
            Thread.Sleep(2000);

            #endregion

            Console.Write("Test Case Closed:");
            Driver.Close();
            Driver.Quit();
        }
    }
}
