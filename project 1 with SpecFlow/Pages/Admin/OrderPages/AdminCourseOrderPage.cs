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
    public class AdminCourseOrderPage
    {
        //1: Elements on Page
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/table/tbody/tr[1]/td[1]/span")]
        public IWebElement orderNumber;

        //1.1: Btn
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div/a[2]")]
        public IWebElement ToClassOrderBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/form/div[2]/button")]
        public IWebElement searchBtn;

        //1.2: List
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/table/tbody")]
        public IWebElement courseList;

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
        //2.1: Click
        public void ClickSearchBtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/form/div[2]/button")));

            searchBtn.Click();
        }
        public void ClickToClassOrderBtn()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[1]/div/a[2]")));

            ToClassOrderBtn.Click();
        }

        //2.2: Assertion Functions
        public void CheckOrderListExists()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div[2]/table/tbody")));

            Assert.IsTrue(courseList.Displayed);
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

            //Using IJavaScriptExecutor
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.Driver2;
            js.ExecuteScript("document.getElementById('startDate').setAttribute('value', '" + startDate + "')");

            //js.ExecuteScript("document.getElementById('startDate').value = '" + startDate + "'");

            //js.ExecutorScript("window.location='http://www.migang.com';");
            ////		向下滚动 
            //js.ExecuteScript("window.scrollBy(0,1900);");
            //Thread.Sleep(2000);
            ////		向上滚动，注意里面的值，也就是纵横坐标
            //js.ExecuteScript("window.scrollBy(0,-1900);");
            //Thread.Sleep(2000);
            ////		定位的元素
            //IWebElement element = driver.FindElement(By.xpath("//span[contains(text(),'米缸公告')]"));
            //Thread.Sleep(2000);
            //// js滚动到出现元素的位置
            //js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            //// 这里向上滚一点，避免上面的元素被其他样式遮住，导致后面元素操作错误。
            //js.ExecuteScript("window.scrollBy(0,-300);");


            //startDateInput.SendKeys(startDate);

            new Actions(Browser.Driver2).SendKeys(Keys.Escape).Perform();

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
