using OpenQA.Selenium;
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
    public class AdminManagementBackEndPage
    {
        //0: Element on Page

        //0.1: btn
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/ul[1]/li[4]/a")]
        public IWebElement orderBtn;

        


        //1: Functions

        //1.1: Click functions
        public void ClickOrderBtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[4]/a")));

            orderBtn.Click();
        }
    }
}
