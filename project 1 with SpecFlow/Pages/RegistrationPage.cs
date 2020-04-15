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
    public class RegistrationPage
    {
        //0: Variables

        //0.1: email
        string expectedEmailError = "请输入有效的电子邮件地址";

        //0.2: username
        string expectedUserNameTextTypeError = "只支持中文字、英文字母、数字及_ . ·";
        string expectedShortUserNameError = "字符长度必须大于等于4，一个中文字算2个字符";
        string expectedLongUserNameError = "字符长度必须小于等于18，一个中文字算2个字符";

        //0.3: password
        string expectedShortPasswordError = "最少需要输入 5 个字符";
        string expectedLongPasswordError = "最多只能输入 20 个字符";

        //0.4: captcha
        string expectedCaptchaTextTypeError = "必须是英文字母、数字及下划线组成";
        string expectedIncorrectCaptchaError = "验证码错误";



        //1: Elements on Page
        [FindsBy(How = How.Id, Using = "register-btn")]
        public readonly IWebElement registerBtn;

        [FindsBy(How = How.Id, Using = "register_email")]
        public IWebElement emailInput;

        [FindsBy(How = How.Id, Using = "register_nickname")]
        public IWebElement userNameInput;

        [FindsBy(How = How.Id, Using = "register_password")]
        public IWebElement passwordInput;

        [FindsBy(How = How.Id, Using = "captcha_code")]
        public IWebElement captchaInput;

        //1.1: Error msg Elements
        [FindsBy(How = How.Id, Using = "register_email-error")]
        public readonly IWebElement emailError;

        [FindsBy(How = How.Id, Using = "register_nickname-error")]
        public readonly IWebElement userNameError;

        [FindsBy(How = How.Id, Using = "register_password-error")]
        public readonly IWebElement passwordError;

        [FindsBy(How = How.Id, Using = "captcha_code-error")]
        public readonly IWebElement capchaError;





        //2: Functions
        public void ClickRegisterBtn()
        {
            WebDriverWait waitRB = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitRB.Until(ExpectedConditions.ElementIsVisible(By.Id("register-btn")));

            registerBtn.Click();
        }

        //2.1: Input functions

        //Email
        public void EnterInvalidEmail(string invalidEmail)
        {
            WebDriverWait waitEmail = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitEmail.Until(ExpectedConditions.ElementIsVisible(By.Id("register_email")));

            emailInput.SendKeys("invalidEmail");
        }

        //User Name
        public void EnterInvalidTextTypeUserName(string invalidTextType)
        {
            WebDriverWait waitTT = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitTT.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname")));

            userNameInput.SendKeys(invalidTextType);
        }

        public void EnterShortUserName(string shortUserName)
        {
            WebDriverWait waitTT = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitTT.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname")));

            userNameInput.SendKeys(shortUserName);
        }

        public void EnterLongUserName(string longUserName)
        {
            WebDriverWait waitTT = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitTT.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname")));

            userNameInput.SendKeys(longUserName);
        }

        //Password
        public void EnterShortPassword(string shortPassword)
        {
            WebDriverWait waitTT = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitTT.Until(ExpectedConditions.ElementIsVisible(By.Id("register_password")));

            passwordInput.SendKeys(shortPassword);
        }

        public void EnterLongPassword(string longPassword)
        {
            WebDriverWait waitTT = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitTT.Until(ExpectedConditions.ElementIsVisible(By.Id("register_password")));

            passwordInput.SendKeys(longPassword);
        }

        //Captcha
        public void EnterInvalidTextTypeCaptcha(string invalidTextType)
        {
            WebDriverWait waitCaptcha = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitCaptcha.Until(ExpectedConditions.ElementIsVisible(By.Id("captcha_code")));

            captchaInput.SendKeys(invalidTextType);
        }

        public void EnterIncorrectCaptcha(string incorrectCaptcha)
        {
            WebDriverWait waitCaptcha = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitCaptcha.Until(ExpectedConditions.ElementIsVisible(By.Id("captcha_code")));

            captchaInput.SendKeys(incorrectCaptcha);
        }


        //2.2: Assertion functions
        public void CheckBlankErrorMsgExists()
        {
            //Make sure the registration form is loaded up
            WebDriverWait waitForm = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitForm.Until(ExpectedConditions.ElementIsVisible(By.Id("register-form")));

            //Test if the error msg exists

            //Email error
            Assert.AreEqual(emailError.Text, "请输入邮箱");
            //User name error
            Assert.AreEqual(userNameError.Text, "请输入用户名");
            //Password error
            Assert.AreEqual(passwordError.Text, "请输入密码");
            //Captcha error
            Assert.AreEqual(capchaError.Text, "请输入验证码");           
        }

        //email error: 请输入有效的电子邮件地址
        public void CheckEmailErrorExists()
        {
            WebDriverWait waitEmail = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitEmail.Until(ExpectedConditions.ElementIsVisible(By.Id("register_email-error")));

            Assert.AreEqual(emailError.Text, expectedEmailError);
        }

        //user name error: 只支持中文字、英文字母、数字及_ . ·
        public void CheckUserNameTextTypeErrorExists()
        {
            WebDriverWait waitUsername = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitUsername.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname-error")));

            Assert.AreEqual(userNameError.Text, expectedUserNameTextTypeError);
        }

        //user name error: 字符长度必须大于等于4，一个中文字算2个字符
        public void CheckShortUserNameError()
        {
            WebDriverWait waitUsername = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitUsername.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname-error")));

            Assert.AreEqual(userNameError.Text, expectedShortUserNameError);
        }

        //user name error: 字符长度必须小于等于18，一个中文字算2个字符
        public void CheckLongUserNameError()
        {
            WebDriverWait waitUsername = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitUsername.Until(ExpectedConditions.ElementIsVisible(By.Id("register_nickname-error")));

            Assert.AreEqual(userNameError.Text, expectedLongUserNameError);
        }

        //password error: 最少需要输入 5 个字符
        public void CheckShortPassword()
        {
            WebDriverWait waitPassword = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitPassword.Until(ExpectedConditions.ElementIsVisible(By.Id("register_password-error")));

            Assert.AreEqual(passwordError.Text, expectedShortPasswordError);
        }

        //password error: 最多只能输入 20 个字符
        public void CheckLongPassword()
        {
            WebDriverWait waitPassword = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitPassword.Until(ExpectedConditions.ElementIsVisible(By.Id("register_password-error")));

            Assert.AreEqual(passwordError.Text, expectedLongPasswordError);
        }

        //captcha error: 必须是英文字母、数字及下划线组成
        public void CheckInvalidTextTypeCaptcha()
        {
            WebDriverWait waitPassword = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitPassword.Until(ExpectedConditions.ElementIsVisible(By.Id("captcha_code-error")));

            Assert.AreEqual(capchaError.Text, expectedCaptchaTextTypeError);
        }

        //captcha error: 验证码错误
        public void CheckIncorreectCaptcha()
        {
            WebDriverWait waitPassword = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 10));
            waitPassword.Until(ExpectedConditions.ElementIsVisible(By.Id("captcha_code-error")));

            Assert.AreEqual(capchaError.Text, expectedIncorrectCaptchaError);
        }
    }
}
