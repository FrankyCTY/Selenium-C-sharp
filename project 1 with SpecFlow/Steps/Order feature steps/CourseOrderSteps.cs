using project_1_with_SpecFlow.Helpers;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace project_1_with_SpecFlow.Steps.Order_feature_steps
{
    [Binding]
    public class CourseOrderSteps
    {
        [Given(@"I have logged in to the admin account")]
        public void GivenIHaveLoggedInToTheAdminAccount(Table table)
        {
            BasePage.MainPage.GoTo();
            BasePage.MainPage.ClickLogInButton();
            BasePage.LogInPage.EnterUserName(table.Rows[0][0]);
            BasePage.LogInPage.EnterPassword(table.Rows[0][1]);
            BasePage.LogInPage.ClickLogInButton();
        }
        
        [Given(@"I am on the course order page")]
        public void GivenIAmOnTheCourseOrderPage()
        {
            //Go in to the management Back End Page
            BasePage.AdminFirstPage.ClickManagementBEBtn();
            //Click order button
            BasePage.AdminManagementBackEndPage.ClickOrderBtn();
        }
        
        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            BasePage.AdminCourseOrderPage.ClickSearchBtn();
        }
        
        [Then(@"the courses should be shown")]
        public void ThenTheCoursesShouldBeShown()
        {
            BasePage.AdminCourseOrderPage.CheckOrderListExists();
        }

        [Then(@"the courses with ""(.*)"" the order number that have been filtered should be shown")]
        public void ThenTheCoursesWithTheOrderNumberThatHaveBeenFilteredShouldBeShown(string orderNum)
        {
            BasePage.AdminCourseOrderPage.CheckAOrderNumberExists(orderNum);
        }


        [Given(@"I have set up the filter ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void GivenIHaveSetUpTheFilter1(string startDate, string paymentStatus, string paymentWay, string keywordType, string keyword)
        {
            BasePage.AdminCourseOrderPage.SelectFilter(startDate, paymentStatus, paymentWay, keywordType, keyword);
        }



    }
}
