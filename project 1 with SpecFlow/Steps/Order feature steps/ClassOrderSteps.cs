using project_1_with_SpecFlow.Helpers;
using System;
using TechTalk.SpecFlow;

namespace project_1_with_SpecFlow.Steps.Order_feature_steps
{
    [Binding]
    public class ClassOrderSteps
    {
        [Given(@"I am on the class order page")]
        public void GivenIAmOnTheClassOrderPage()
        {
            //Go in to the management Back End Page
            BasePage.AdminFirstPage.ClickManagementBEBtn();
            //Click order button
            BasePage.AdminManagementBackEndPage.ClickOrderBtn();
            //Click to class order button
            BasePage.AdminCourseOrderPage.ClickToClassOrderBtn();
        }
        
        [When(@"I press the search button in the class order page")]
        public void WhenIPressTheSearchButtonInTheClassOrderPage()
        {
            BasePage.AdminClassOrderPage.ClickSearchBtn();
        }
        
        [Then(@"the class I have ordered should be shown")]
        public void ThenTheClassIHaveOrderedShouldBeShown()
        {
            BasePage.AdminClassOrderPage.CheckClassOrderListExists();
        }

        [Given(@"I have set up the filters for class ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)"" ""(.*)""")]
        public void GivenIHaveSetUpTheFiltersForClass(string startDate, string paymentStatus, string paymentWay, string keywordType, string keyword)
        {
            BasePage.AdminClassOrderPage.SelectFilter(startDate, paymentStatus, paymentWay, keywordType, keyword);
        }

        [Then(@"the classes with ""(.*)"" the order number that have been filtered should be shown")]
        public void ThenTheClassesWithTheOrderNumberThatHaveBeenFilteredShouldBeShown(string orderNumber)
        {
            BasePage.AdminClassOrderPage.CheckAOrderNumberExists(orderNumber);
        }

    }
}
