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

namespace project_1_with_SpecFlow.Pages.PersonalSettingPages
{
    public class FundamentalInformationPage
    {
        //0: Variables

        //0.1: Error Message
        //name
        string shortNameErrorMsg = "最少需要输入 2 个字符";
        string longNameErrorMsg = "最多只能输入 18 个字符";
        //ID number
        string invalidIDNumErrorMsg = "请正确输入您的身份证号码";
        //phone number
        string invalidPHErrorMsg = "请输入正确的手机号";
        //title
        string longTitleErrorMsg = "最多只能输入 24 个字符";
        //site && Weibo
        string invalidAddressMsg = "地址不正确，须以http://或者https://开头。";
        //qq
        string invalidQQErrorMsg = "请输入正确的QQ号";




        //1: Elements on Page

        //1.1: Input
        //name
        [FindsBy(How = How.Id, Using = "profile_truename")]
        public readonly IWebElement nameInput;

        //ID number
        [FindsBy(How = How.Id, Using = "profile_idcard")]
        public readonly IWebElement idNumInput;

        //phone number
        [FindsBy(How = How.Id, Using = "profile_mobile")]
        public readonly IWebElement mobileInput;

        //title
        [FindsBy(How = How.Id, Using = "profile_title")]
        public readonly IWebElement titleInput;

        //site
        [FindsBy(How = How.Id, Using = "profile_site")]
        public readonly IWebElement siteInput;

        //Weibo
        [FindsBy(How = How.Id, Using = "weibo")]
        public readonly IWebElement weiboInput;

        //qq
        [FindsBy(How = How.Id, Using = "profile_qq")]
        public readonly IWebElement qqInput;

        //1.2: Error msg elements
        //name
        [FindsBy(How = How.Id, Using = "profile_truename-error")]
        public readonly IWebElement shortNameError;

        [FindsBy(How = How.Id, Using = "profile_truename-error")]
        public readonly IWebElement longNameError;
        //id number
        [FindsBy(How = How.Id, Using = "profile_idcard-error")]
        public readonly IWebElement invalidIdError;
        //phone
        [FindsBy(How = How.Id, Using = "profile_mobile-error")]
        public readonly IWebElement invalidPhoneError;
        //title
        [FindsBy(How = How.Id, Using = "profile_title-error")]
        public readonly IWebElement invalidTitleError;
        //site
        [FindsBy(How = How.Id, Using = "profile_site-error")]
        public readonly IWebElement invalidSiteError;
        //weibo
        [FindsBy(How = How.Id, Using = "weibo-error")]
        public readonly IWebElement invalidWeiboError;
        //QQ
        [FindsBy(How = How.Id, Using = "profile_qq-error")]
        public readonly IWebElement invalidQQError;

        //1.3: Btn
        //Save btn
        [FindsBy(How = How.Id, Using = "profile-save-btn")]
        public readonly IWebElement saveButton;



        //2: Functions
        //2.1: Click
        public void ClickSaveBtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile-save-btn")));

            saveButton.Click();
        }


        //2.2: Enter
        //Name
        public void EnterShortName(string shortName)
        {
            WebDriverWait waitNameInput = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitNameInput.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_truename")));

            nameInput.Clear();
            nameInput.SendKeys(shortName);
        }

        public void EnterLongName(string longName)
        {
            WebDriverWait waitNameInput = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitNameInput.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_truename")));

            nameInput.Clear();
            nameInput.SendKeys(longName);
        }

        //ID number
        public void EnterInvalidID(string invalidID)
        {
            WebDriverWait waitIdINput = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitIdINput.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_idcard")));

            idNumInput.Clear();
            idNumInput.SendKeys(invalidID);
        }

        //Phone Number
        public void EnterInvalidPhoneNum(string invalidPhoneNum)
        {
            WebDriverWait waitIdINput = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitIdINput.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_mobile")));

            mobileInput.Clear();
            mobileInput.SendKeys(invalidPhoneNum);
        }

        //Title
        public void EnterTooLongTitle(string longTitle)
        {
            WebDriverWait waitTitleInput = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitTitleInput.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_title")));

            titleInput.Clear();
            titleInput.SendKeys(longTitle);
        }

        //Site
        public void EnterInvalidSite(string invalidSite)
        {
            WebDriverWait waitSiteInput = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitSiteInput.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_site")));

            siteInput.Clear();
            siteInput.SendKeys(invalidSite);
        }
        //Weibo
        public void EnterInvalidWeibo(string invalidWeibo)
        {
            WebDriverWait waitWeiboInput = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitWeiboInput.Until(ExpectedConditions.ElementIsVisible(By.Id("weibo")));

            weiboInput.Clear();
            weiboInput.SendKeys(invalidWeibo);
        }
        //QQ
        public void EnterInvalidQQ(string invalidQQ)
        {
            WebDriverWait waitWeiboInput = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitWeiboInput.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_qq")));

            qqInput.Clear();
            qqInput.SendKeys(invalidQQ);
        }



        //2.3: Assertion Functions
        //Name
        public void CheckShortNameER()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_truename-error")));

            Assert.AreEqual(shortNameError.Text, shortNameErrorMsg);
        }

        public void CheckLongNameER()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_truename-error")));

            Assert.AreEqual(longNameError.Text, longNameErrorMsg);
        }

        //ID number
        public void CheckInvalidID()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_idcard-error")));

            Assert.AreEqual(invalidIdError.Text, invalidIDNumErrorMsg);
        }

        //Phone Number
        public void CheckInvalidPhoneNum()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_mobile-error")));

            Assert.AreEqual(invalidPhoneError.Text, invalidPHErrorMsg);
        }

        //Title
        public void CheckTooLongTitle()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_title-error")));

            Assert.AreEqual(invalidTitleError.Text, longTitleErrorMsg);
        }
        //Site
        public void CheckInvalidSite()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_site-error")));

            Assert.AreEqual(invalidSiteError.Text, invalidAddressMsg);
        }
        //Weibo
        public void CheckInvalidWeibo()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("weibo-error")));

            Assert.AreEqual(invalidWeiboError.Text, invalidAddressMsg);
        }
        //QQ
        public void CheckInvalidQQ()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("profile_qq-error")));

            Assert.AreEqual(invalidQQError.Text, invalidQQErrorMsg);
        }
    }
}
