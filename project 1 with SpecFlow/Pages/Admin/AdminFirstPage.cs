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

namespace project_1_with_SpecFlow.Pages.Admin
{
    public class AdminFirstPage
    {
        //1: Elements on page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/a/img")]
        public IWebElement avatar;

        //1.1: btn
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[6]/a")]
        public IWebElement managementBackEndBtn;


        //2: Functions

        //2.1: Click Functions
        public void ClickManagementBEBtn()
        {
            //Wait for drop down list
            WebDriverWait waitDropDownList = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitDropDownList.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/a/img")));

            //Hover on drop down list to open it
            new Actions(Browser.Driver2).MoveToElement(avatar).Perform();

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/ul/li[1]/ul/li[6]/a")));

            //managementBackEndBtn.Click();
            new Actions(Browser.Driver2).Click(managementBackEndBtn).Perform();
        }


    }
}
