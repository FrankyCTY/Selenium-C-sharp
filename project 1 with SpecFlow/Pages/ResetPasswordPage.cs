using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using project_1_with_SpecFlow.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1_with_SpecFlow.Pages
{
    public class ResetPasswordPage
    {
        //0: Variables


        //0.1: Error message
        string emptyEmailErrorMsg = "请输入邮箱地址";
        string invalidEmailErrorMsg = "请输入有效的电子邮件地址";
        string emailNotFoundErrorMsg = "该邮箱地址没有注册过帐号";



        //1: Elements on Page

        //1.1: Buttons
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div/div/form[1]/div[2]/div/button")]
        public readonly IWebElement resetPasswordBtn;

        //1.2: Input
        [FindsBy(How = How.Id, Using = "form_email")]
        public readonly IWebElement emailInput;

        //1.3 Error msg element
        [FindsBy(How = How.Id, Using = "form_email-error")]
        public readonly IWebElement emptyInputError;

        [FindsBy(How = How.Id, Using = "form_email-error")]
        public readonly IWebElement invalidInputError;

        [FindsBy(How = How.Id, Using = "alertxx")]
        public readonly IWebElement emailNotFoundError;

        //2: Functions
        public void ClickResetPWBtn()
        {
            WebDriverWait waitPWBtn = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitPWBtn.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div/div/form[1]/div[2]/div/button")));

            resetPasswordBtn.Click();
        }

        public void EnterInvalidEmail(string invalidEmail)
        {
            WebDriverWait waitEmailBar = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitEmailBar.Until(ExpectedConditions.ElementIsVisible(By.Id("form_email")));

            emailInput.SendKeys(invalidEmail);
        }

        public void EnterNotRegisteredEmail(string email)
        {
            WebDriverWait waitEmailBar = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitEmailBar.Until(ExpectedConditions.ElementIsVisible(By.Id("form_email")));

            emailInput.SendKeys(email);
        }

        //2.1: Assertion Functions
        public void CheckEmptyInputEr()
        {
            WebDriverWait waitER = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitER.Until(ExpectedConditions.ElementIsVisible(By.Id("form_email-error")));

            Assert.AreEqual(emptyInputError.Text, emptyEmailErrorMsg);
        }

        public void CheckInvalidEmailEr()
        {
            WebDriverWait waitER = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitER.Until(ExpectedConditions.ElementIsVisible(By.Id("form_email-error")));

            Assert.AreEqual(invalidInputError.Text, invalidEmailErrorMsg);

        }

        public void CheckNotRegisteredEmailEr()
        {
            WebDriverWait waitER = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitER.Until(ExpectedConditions.ElementIsVisible(By.Id("alertxx")));

            Assert.AreEqual(emailNotFoundError.Text, emailNotFoundErrorMsg);
        }
    }
}
