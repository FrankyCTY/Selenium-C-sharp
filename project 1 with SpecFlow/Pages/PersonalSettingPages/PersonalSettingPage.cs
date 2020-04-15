using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using project_1_with_SpecFlow.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using System.Threading;

namespace project_1_with_SpecFlow.Pages
{
    public class PersonalSettingPage
    {
        //Elements on Page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[1]/div/ul/li[3]/a")]
        public IWebElement avatarSetting;


        //Functions
        public void ClickAvatarSetting()
        {
            WebDriverWait waitAS = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitAS.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[1]/div/ul/li[3]/a")));

            //new Actions(Browser.Driver2).Click(avatarSetting).Perform();
            avatarSetting.Click();
        }
    }
}
