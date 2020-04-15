using project_1_with_SpecFlow.Helpers;
using System;
using TechTalk.SpecFlow;

namespace project_1_with_SpecFlow.Steps
{
    [Binding]
    public class ResetPasswordSteps
    {
        [Given(@"I am on the reset password page")]
        public void GivenIAmOnTheResetPasswordPage()
        {
            BasePage.MainPage.GoTo();
            BasePage.MainPage.ClickLogInButton();
            BasePage.LogInPage.ClickResetPWBtn();
        }
        
        [Given(@"I have enetered nothing for the email")]
        public void GivenIHaveEneteredNothingForTheEmail()
        {
            Console.WriteLine("Eneter nothing for the email");
        }
        
        [When(@"I press reset password")]
        public void WhenIPressResetPassword()
        {
            BasePage.ResetPasswordPage.ClickResetPWBtn();
        }
        
        [Then(@"error 请输入邮箱地址 should be shown on screen")]
        public void ThenError请输入邮箱地址ShouldBeShownOnScreen()
        {
            BasePage.ResetPasswordPage.CheckEmptyInputEr();
        }

        [Given(@"I have enetered ""(.*)"" invalid email")]
        public void GivenIHaveEneteredInvalidEmail(string p0)
        {
            BasePage.ResetPasswordPage.EnterInvalidEmail(p0);
        }

        [Then(@"error 请输入有效的电子邮件地址 should be shown on screen")]
        public void ThenError请输入有效的电子邮件地址ShouldBeShownOnScreen()
        {
            BasePage.ResetPasswordPage.CheckInvalidEmailEr();
        }

        [Given(@"I have enetered ""(.*)"" not registered email")]
        public void GivenIHaveEneteredNotRegisteredEmail(string p0)
        {
            BasePage.ResetPasswordPage.EnterNotRegisteredEmail(p0);
        }

        [Then(@"error 该邮箱地址没有注册过帐号 should be shown on screen")]
        public void ThenError该邮箱地址没有注册过帐号ShouldBeShownOnScreen()
        {
            BasePage.ResetPasswordPage.CheckNotRegisteredEmailEr();
        }


    }
}
