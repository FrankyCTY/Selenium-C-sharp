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

namespace project_1_with_SpecFlow.Pages.PersonalSettingPages
{
    public class AvatarSettingPage
    {
        //----------------------------Avatar Setting SECTION---------------------------------

        //Variables
        readonly string filePath = @"C:\Users\FrankyVenus\Desktop\1.jpg";

        //Elements On Page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div/div[2]/div/div[2]/form/div[3]/div[2]/a/div[2]/input")]
        public IWebElement uploadNewAvatar;

        [FindsBy(How = How.Id, Using = "upload-avatar-btn")]
        public IWebElement saveBtn;

        //[FindsBy(How = How.XPath, Using = "//*[@id='upload - avatar - btn']")]
        //public IWebElement saveBtn;


        //Function

        //UpLoad avatar
        public void UploadAvatar()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div/div[2]/form/div[3]/div[2]/a/div[2]/input")));

            //Approach 1: SendKeys
            uploadNewAvatar.SendKeys(filePath);

            ////Approach 2: AutoIT - Handles Windows that do not belong to browser


            //Open the "File Upload" window first

            //uploadNewAvatar.Click(); //It doesn't work for input type element

            //AutoItX3 autoIt = new AutoItX3();

            ////Activate the window with the title - so that we can perform action on the specific window
            //autoIt.WinActivate("File Upload");

            //autoIt.Send(filePath);

            //Thread.Sleep(2000);
            //autoIt.Send("{ENTER}");


            //Press SAVE btn

            //Wait for button to be visible
            WebDriverWait waitSave = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitSave.Until(ExpectedConditions.ElementIsVisible(By.Id("upload-avatar-btn")));

            //WebDriverWait waitSave = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            //waitSave.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='upload - avatar - btn']")));

            //Wait for new picture being uploaded
            WebDriverWait wait3 = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/div/div[2]/div/div[2]/form/div[1]/div/div[1]/canvas")));

            //Get CSS value
            string bkColor = saveBtn.GetCssValue("background-color");
            Console.WriteLine(bkColor);

            string color = saveBtn.GetCssValue("color");
            Console.WriteLine(color);

            saveBtn.Click();


            Thread.Sleep(5000);
            //Console.WriteLine("HI");





        }
    }
}
