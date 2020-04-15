using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using project_1_with_SpecFlow.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace project_1_with_SpecFlow.Pages
{
    public class MainPage
    {
        //Elements on page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[2]/a")]
        public readonly IWebElement logInButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[3]/a")]
        public readonly IWebElement registerBtn;

        //Home Page url
        string url = ConfigurationManager.AppSettings.Get("baseUrl");

        //Function
        public void GoTo()
        {
            Browser.GoTo(url);
        }

        public void ClickLogInButton()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[2]/a")));
            logInButton.Click();
        }

        public void ClickRegisterBtn()
        {
            WebDriverWait waitRB = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitRB.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[3]/a")));
            registerBtn.Click();
        }

    }
}
