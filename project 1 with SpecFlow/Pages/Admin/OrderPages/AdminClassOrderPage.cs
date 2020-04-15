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
using System.Threading.Tasks;

namespace project_1_with_SpecFlow.Pages.Admin.OrderPages
{
    public class AdminClassOrderPage
    {
        //1: Elements On Page
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/table/tbody/tr[1]/td[1]/span")]
        public IWebElement orderNumber;

        //1.1: Btn
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/button")]
        public IWebElement searchBtn;

        //1.2: List
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/table/tbody")]
        public IWebElement orderList;

        //1.3: Filter element
        [FindsBy(How = How.Id, Using = "startDate")]
        public IWebElement startDateInput;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[1]")]
        public IWebElement paymentStatusList;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")]
        public IWebElement paymentWayList;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[3]/select")]
        public IWebElement keywordTypeList;

        //Input
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/div[3]/input")]
        public IWebElement keywordInput;

        //2: Functions

        //2.1: Click Functions
        public void ClickSearchBtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/button")));

            searchBtn.Click();
        }

        //2.2: Assertion Functions
        public void CheckClassOrderListExists()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/table/tbody")));

            Assert.IsTrue(orderList.Displayed);
        }

        public void CheckAOrderNumberExists(string orderNum)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/table/tbody/tr[1]/td[1]/span")));

            Assert.IsTrue(orderNumber.Text.Contains(orderNum));
        }

        //2.3: Selection
        public void SelectFilter(string startDate, string paymentStatus, string paymentWay, string keywordType, string keyword)
        {
            //Start date
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("startDate")));

            //startDateInput.SendKeys(startDate);

            ////press escape key to close the datetime picker
            //new Actions(Browser.Driver2).SendKeys(Keys.Escape).Perform();

            //Using IJavaScriptExecutor
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.Driver2;
            js.ExecuteScript("document.getElementById('startDate').setAttribute('value', '" + startDate + "')");

            //Payment status
            WebDriverWait waitPS = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitPS.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[1]")));

            SelectElement paymentStatusSelect = new SelectElement(paymentStatusList);

            paymentStatusSelect.SelectByValue(paymentStatus);

            //Payment way
            WebDriverWait waitPW = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitPW.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[1]/select[2]")));

            SelectElement paymentWaySelect = new SelectElement(paymentWayList);

            paymentWaySelect.SelectByValue(paymentWay);

            //Keyword type
            WebDriverWait waitKT = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitKT.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[3]/select")));

            SelectElement keywordTypeSelect = new SelectElement(keywordTypeList);

            keywordTypeSelect.SelectByValue(keywordType);

            //Keyword
            WebDriverWait waitKeyword = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitKeyword.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/div[3]/input")));

            keywordInput.SendKeys(keyword);
        }
    }
}
