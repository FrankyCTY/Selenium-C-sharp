using project_1_with_SpecFlow.Helpers;
using System;
using TechTalk.SpecFlow;

namespace project_1_with_SpecFlow
{
    [Binding]
    public class LogInFeatureSteps
    {
        [Given(@"I am in the Log In Page")]
        public void GivenIAmInTheLogInPage()
        {
            BasePage.MainPage.GoTo();
            BasePage.MainPage.ClickLogInButton();
        }
        
        [When(@"I enter the correct user name and correct password")]
        public void WhenIEnterTheCorrectUserNameAndCorrectPassword(Table table)
        {
            BasePage.LogInPage.EnterUserName(table.Rows[0][0]);
            BasePage.LogInPage.EnterPassword(table.Rows[0][1]);
        }
        
        [When(@"I press the log in button")]
        public void WhenIPressTheLogInButton()
        {
            BasePage.LogInPage.ClickLogInButton();
        }
        
        [When(@"I ticked the remember me radio box")]
        public void WhenITickedTheRememberMeRadioBox()
        {
            BasePage.LogInPage.ClickRememberMe();
        }
        
        [When(@"I enter the incorrect user name and correct password")]
        public void WhenIEnterTheIncorrectUserNameAndCorrectPassword(Table table)
        {
            BasePage.LogInPage.EnterUserName(table.Rows[0][0]);
            BasePage.LogInPage.EnterPassword(table.Rows[0][1]);
        }
        
        [Then(@"I can log in to my account and see my avatar on the web page")]
        public void ThenICanLogInToMyAccountAndSeeMyAvatarOnTheWebPage()
        {
            BasePage.FirstPage.CheckAvatarVisible();
        }
        
        [Then(@"I can see the error message")]
        public void ThenICanSeeTheErrorMessage()
        {
            BasePage.LogInPage.ErrorMessageVisible();
        }

        [Then(@"I can log out my account")]
        public void ThenICanLogOutMyAccount()
        {
            BasePage.FirstPage.ClickLogOut();
            BasePage.LogInPage.AssertUserNameVisible();
        }

    }
}
