using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1_with_SpecFlow.Helpers
{
    public static class Browser
    {
        static IWebDriver webDriver;

        public static void InitDriver()
        {
            webDriver = new FirefoxDriver();
        }


        //Browser commands
        public static string Title
        {
            get
            {
                return webDriver.Title;
            }
        }

        public static string PageSource
        {
            get
            {
                return webDriver.PageSource;
            }
        }

        //web driver commands
        public static ISearchContext Driver
        {
            get
            {
                return webDriver;
            }
        }

        public static IWebDriver Driver2
        {
            get
            {
                return webDriver;
            }
        }

        //Navigation commands
        public static void Back()
        {
            webDriver.Navigate().Back();
        }
        public static void Forward()
        {
            webDriver.Navigate().Forward();
        }
        public static void Refresh()
        {
            webDriver.Navigate().Refresh();
        }

        //GoTo MainPage
        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        //Close all website that opened by web driver
        public static void CloseAll()
        {
            webDriver.Quit();
        }
    }
}
