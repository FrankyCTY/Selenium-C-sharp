using project_1_with_SpecFlow.Helpers;
using System;
using TechTalk.SpecFlow;

namespace project_1_with_SpecFlow.Steps
{
    [Binding]
    public class FundamentalInformationSteps
    {
        [Given(@"I am logged into my account")]
        public void GivenIAmLoggedIntoMyAccount(Table table)
        {
            BasePage.MainPage.GoTo();
            BasePage.MainPage.ClickLogInButton();
            //Enter username and password
            BasePage.LogInPage.EnterUserName(table.Rows[0][0]);
            BasePage.LogInPage.EnterPassword(table.Rows[0][1]);
            BasePage.LogInPage.ClickLogInButton();
        }
        
        [Given(@"I am on the fundamental information page")]
        public void GivenIAmOnTheFundamentalInformationPage()
        {
            BasePage.FirstPage.ClickPersonalSetting();
        }
        
        [Given(@"I entered ""(.*)"" less than (.*) characters for the name")]
        public void GivenIEnteredLessThanCharactersForTheName(string p0, int p1)
        {
            BasePage.FundamentalInformationPage.EnterShortName(p0);
        }
        
        [When(@"I press save")]
        public void WhenIPressSave()
        {
            BasePage.FundamentalInformationPage.ClickSaveBtn();
        }
        
        [Then(@"error msg 最少需要输入 2 个字符 should be shown under the name input")]
        public void ThenErrorMsg最少需要输入个字符ShouldBeShownUnderTheNameInput()
        {
            BasePage.FundamentalInformationPage.CheckShortNameER();
        }

        [Given(@"I entered ""(.*)"" more than 18 characters for the name")]
        public void GivenIEnteredMoreThanCharactersForTheName(string p0)
        {
            BasePage.FundamentalInformationPage.EnterLongName(p0);
        }

        [Then(@"error msg 最多只能输入 (.*) 个字符 should be shown under the name input")]
        public void ThenErrorMsg最多只能输入个字符ShouldBeShownUnderTheNameInput(int p0)
        {
            BasePage.FundamentalInformationPage.CheckLongNameER();
        }

        [Given(@"I entered ""(.*)"" invalid ID number")]
        public void GivenIEnteredInvalidIDNumber(string p0)
        {
            BasePage.FundamentalInformationPage.EnterInvalidID(p0);
        }



        [Given(@"I entered ""(.*)"" invalid phone number")]
        public void GivenIEnteredInvalidPhoneNumber(string p0)
        {
            BasePage.FundamentalInformationPage.EnterInvalidPhoneNum(p0);
        }

        [Then(@"error msg 请正确输入您的身份证号码 should be shown under the ID number input")]
        public void ThenErrorMsg请正确输入您的身份证号码ShouldBeShownUnderTheIDNumberInput()
        {
            BasePage.FundamentalInformationPage.CheckInvalidID();
        }

        [Then(@"error msg 请输入正确的手机号 should be shown under the phone number input")]
        public void ThenErrorMsg请输入正确的手机号ShouldBeShownUnderThePhoneNumberInput()
        {
            BasePage.FundamentalInformationPage.CheckInvalidPhoneNum();
        }

        [Given(@"I entered ""(.*)"" too long title")]
        public void GivenIEnteredTooLongTitle(string p0)
        {
            BasePage.FundamentalInformationPage.EnterTooLongTitle(p0);
        }

        [Then(@"error msg 最多只能输入 24 个字符 should be shown under the title input")]
        public void ThenErrorMsg最多只能输入个字符ShouldBeShownUnderTheTitleInput()
        {
            BasePage.FundamentalInformationPage.CheckTooLongTitle();
        }

        [Given(@"I entered ""(.*)"" invalid site")]
        public void GivenIEnteredInvalidSite(string p0)
        {
            BasePage.FundamentalInformationPage.EnterInvalidSite(p0);
        }

        [Then(@"error msg 地址不正确，须以http://或者https://开头。 should be shown under the site input")]
        public void ThenErrorMsg地址不正确须以Http或者Https开头ShouldBeShownUnderTheSiteInput()
        {
            BasePage.FundamentalInformationPage.CheckInvalidSite();
        }

        [Given(@"I entered ""(.*)"" invalid weibo")]
        public void GivenIEnteredInvalidWeibo(string p0)
        {
            BasePage.FundamentalInformationPage.EnterInvalidWeibo(p0);
        }

        [Then(@"error msg 地址不正确，须以http://或者https://开头。 should be shown under the weibo input")]
        public void ThenErrorMsg地址不正确须以Http或者Https开头ShouldBeShownUnderTheWeiboInput()
        {
            BasePage.FundamentalInformationPage.CheckInvalidWeibo();
        }
        [Given(@"I entered ""(.*)"" invalid QQ")]
        public void GivenIEnteredInvalidQQ(string p0)
        {
            BasePage.FundamentalInformationPage.EnterInvalidQQ(p0);
        }

        [Then(@"error msg 请输入正确的QQ号 should be shown under the QQ input")]
        public void ThenErrorMsg请输入正确的QQ号ShouldBeShownUnderTheQQInput()
        {
            BasePage.FundamentalInformationPage.CheckInvalidQQ();
        }

    }
}
