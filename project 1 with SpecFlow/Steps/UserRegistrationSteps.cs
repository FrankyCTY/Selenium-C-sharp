using project_1_with_SpecFlow.Helpers;
using System;
using TechTalk.SpecFlow;

namespace project_1_with_SpecFlow.Steps
{
    [Binding]
    public class UserRegistrationSteps
    {
        [Given(@"I am on the registration page")]
        public void GivenIAmOnTheRegistrationPage()
        {
            BasePage.MainPage.GoTo();
            BasePage.MainPage.ClickRegisterBtn();
        }
        
        [Given(@"I have entered blank information")]
        public void GivenIHaveEnteredBlankInformation()
        {
            Console.WriteLine("Enter nothing in the register page");
        }
        
        [When(@"I press register")]
        public void WhenIPressRegister()
        {
            BasePage.RegistrationPage.ClickRegisterBtn();
        }

        [Then(@"the error message caused by blank input should be shown on the screen")]
        public void ThenTheErrorMessageCausedByBlankInputShouldBeShownOnTheScreen()
        {
            BasePage.RegistrationPage.CheckBlankErrorMsgExists();
        }

        [Given(@"I have entered ""(.*)"" invalid email")]
        public void GivenIHaveEnteredInvalidEmail(string p0)
        {
            BasePage.RegistrationPage.EnterInvalidEmail(p0);
        }



        [Then(@"the error message caused by invalid email should be shown on the screen")]
        public void ThenTheErrorMessageCausedByInvalidEmailShouldBeShownOnTheScreen()
        {
            BasePage.RegistrationPage.CheckEmailErrorExists();
        }

        [Given(@"I have entered ""(.*)"" invalid text input username")]
        public void GivenIHaveEnteredInvalidTextInputUsername(string p0)
        {
            BasePage.RegistrationPage.EnterInvalidTextTypeUserName(p0);
        }

        [Then(@"the error message caused by invalid text input username should be shown on the screen")]
        public void ThenTheErrorMessageCausedByInvalidTextInputUsernameShouldBeShownOnTheScreen()
        {
            BasePage.RegistrationPage.CheckUserNameTextTypeErrorExists();
        }

        [Given(@"I have entered ""(.*)"" too short username")]
        public void GivenIHaveEnteredTooShortUsername(string p0)
        {
            BasePage.RegistrationPage.EnterShortUserName(p0);
        }

        [Then(@"the error message caused by too short username should be shown on the screen")]
        public void ThenTheErrorMessageCausedByTooShortUsernameShouldBeShownOnTheScreen()
        {
            BasePage.RegistrationPage.CheckShortUserNameError();
        }

        [Given(@"I have entered ""(.*)"" too long username")]
        public void GivenIHaveEnteredTooLongUsername(string p0)
        {
            BasePage.RegistrationPage.EnterLongUserName(p0);
        }

        [Then(@"the error message caused by too long username should be shown on the screen")]
        public void ThenTheErrorMessageCausedByTooLongUsernameShouldBeShownOnTheScreen()
        {
            BasePage.RegistrationPage.CheckLongUserNameError();
        }

        [Given(@"I have entered ""(.*)"" too short password")]
        public void GivenIHaveEnteredTooShortPassword(string p0)
        {
            BasePage.RegistrationPage.EnterShortPassword(p0);
        }

        [Then(@"最少需要输入 (.*) 个字符 should be shown on the screen")]
        public void Then最少需要输入个字符ShouldBeShownOnTheScreen(int p0)
        {
            BasePage.RegistrationPage.CheckShortPassword();
        }

        [Given(@"I have entered ""(.*)"" too long password")]
        public void GivenIHaveEnteredTooLongPassword(string p0)
        {
            BasePage.RegistrationPage.EnterLongPassword(p0);
        }

        [Then(@"最多只能输入 (.*) 个字符 should be shown on the screen")]
        public void Then最多只能输入个字符ShouldBeShownOnTheScreen(int p0)
        {
            BasePage.RegistrationPage.CheckLongPassword();
        }

        [Given(@"I have entered ""(.*)"" invalid text type capcha")]
        public void GivenIHaveEnteredInvalidTextTypeCapcha(string p0)
        {
            BasePage.RegistrationPage.EnterInvalidTextTypeCaptcha(p0);
        }

        [Then(@"必须是英文字母、数字及下划线组成 should be shown on the screen")]
        public void Then必须是英文字母数字及下划线组成ShouldBeShownOnTheScreen()
        {
            BasePage.RegistrationPage.CheckInvalidTextTypeCaptcha();
        }

        [Given(@"I have entered ""(.*)"" incorrect capcha")]
        public void GivenIHaveEnteredIncorrectCapcha(string p0)
        {
            BasePage.RegistrationPage.EnterIncorrectCaptcha(p0);
        }

        [Then(@"验证码错误 should be shown on the screen")]
        public void Then验证码错误ShouldBeShownOnTheScreen()
        {
            BasePage.RegistrationPage.CheckIncorreectCaptcha();
        }

    }
}
