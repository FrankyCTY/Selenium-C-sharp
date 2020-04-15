using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using project_1_with_SpecFlow.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project_1_with_SpecFlow.Pages
{
    public class LogInPage
    {
        //Elements on page
        [FindsBy(How = How.XPath, Using = "//*[@id='login_username']")]
        public readonly IWebElement username;

        [FindsBy(How = How.XPath, Using = "//*[@id='login_password']")]
        public readonly IWebElement password;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[3]/div/input")]
        public readonly IWebElement rememberMe;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")]
        public readonly IWebElement logInButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/form/div[1]")]
        public readonly IWebElement errorMessage;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/div/a[1]")]
        public readonly IWebElement resetPWBtn;

        //Functions
        public void EnterUserName(string inputUserName)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='login_username']")));
            username.SendKeys(inputUserName);
        }

        public void EnterPassword(string inputPassword)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='login_password']")));
            password.SendKeys(inputPassword);
        }

        public void ClickRememberMe()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[3]/div/input")));

            //if the radio box is not selected, we click it
            Boolean select = rememberMe.Selected;

            if(!select)
            {
                rememberMe.Click();
            }
        }

        public void ClickLogInButton()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[4]/button")));
            logInButton.Click();
        }

        public void ErrorMessageVisible()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/form/div[1]")));
            //if(errorMessage.Displayed)
            //{
            //    Console.WriteLine("Error Message is displayed!");
            //}

            string ExpectedErrorMsg = "用户名或密码错误";

            Assert.AreEqual(ExpectedErrorMsg, errorMessage.Text);
        }

        public void ClickResetPWBtn()
        {
            WebDriverWait waitRPW = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitRPW.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div/a[1]")));

            resetPWBtn.Click();
        }

        //Assertion
        public void AssertUserNameVisible()
        {
            //Assert that the log in bar exists.
            //Assert.IsTrue(username != null);
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='login_username']")));
            Assert.IsTrue(Browser.Driver.FindElement(By.XPath("//*[@id='login_username']")).Displayed);
        }
    }
}
