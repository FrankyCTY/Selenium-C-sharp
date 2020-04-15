using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    public class FirstPage
    {
        //Elements on page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/a/img")]
        public IWebElement avatar;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]/a")]
        public IWebElement logOut;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[3]/a")]
        public IWebElement personalSetting;



        //Function
        public void CheckAvatarVisible()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));
            if (avatar.Displayed)
            {
                Console.WriteLine("Avatar is displayed!");
            }
            
        }

        public void ClickPersonalSetting()
        {
            //Hover on the drop-down list (Avatar) to open it
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));

            new Actions(Browser.Driver2).MoveToElement(avatar).Perform();

            //Click "Personal Setting"
            WebDriverWait waitPS = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[3]/a")));

            //new Actions(Browser.Driver2).Click(personalSetting).Perform();

            personalSetting.Click();
        }

        public void ClickLogOut()
        {
            //Hover on the drop-down list (Avatar) to open it

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));

            new Actions(Browser.Driver2).MoveToElement(avatar).Perform();

            WebDriverWait wait2 = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[9]/a")));

            //new Actions(Browser.Driver2).Click(logOut).Perform();
            logOut.Click();
        }



    }
}
