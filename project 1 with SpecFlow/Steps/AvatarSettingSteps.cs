using project_1_with_SpecFlow.Helpers;
using System;
using TechTalk.SpecFlow;

namespace project_1_with_SpecFlow.Steps
{
    [Binding]
    public class AvatarSettingSteps
    {
        [Given(@"I have logged in to the account")]
        public void GivenIHaveLoggedInToTheAccount(Table table)
        {
            BasePage.MainPage.GoTo();
            BasePage.MainPage.ClickLogInButton();
            //log in
            BasePage.LogInPage.EnterUserName(table.Rows[0][0]);
            BasePage.LogInPage.EnterPassword(table.Rows[0][1]);
            BasePage.LogInPage.ClickLogInButton();
        }
        
        [Given(@"I am on the personal setting page")]
        public void GivenIAmOnThePersonalSettingPage()
        {
            BasePage.FirstPage.ClickPersonalSetting();
        }
        
        [When(@"I press Avatar setting")]
        public void WhenIPressAvatarSetting()
        {
            BasePage.PersonalSettingPage.ClickAvatarSetting();
        }
        
        [Then(@"I choose a picture from my desktop and press save")]
        public void ThenIChooseAPictureFromMyDesktopAndPressSave()
        {
            BasePage.AvatarSettingPage.UploadAvatar();
        }
    }
}
