using OpenQA.Selenium.Support.PageObjects;
using project_1_with_SpecFlow.Pages;
using project_1_with_SpecFlow.Pages.Admin;
using project_1_with_SpecFlow.Pages.Admin.OrderPages;
using project_1_with_SpecFlow.Pages.PersonalSettingPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1_with_SpecFlow.Helpers
{
    public static class BasePage
    {
        public static MainPage MainPage
        {
            get
            {
                var mainPage = new MainPage();
                PageFactory.InitElements(Browser.Driver, mainPage);
                return mainPage;
            }
        }
        public static LogInPage LogInPage
        {
            get
            {
                var logInPage = new LogInPage();
                PageFactory.InitElements(Browser.Driver, logInPage);
                return logInPage;
            }
        }
        public static FirstPage FirstPage
        {
            get
            {
                var firstPage = new FirstPage();
                PageFactory.InitElements(Browser.Driver, firstPage);
                return firstPage;
            }
        }
        public static PersonalSettingPage PersonalSettingPage
        {
            get
            {
                var personalSettingPage = new PersonalSettingPage();
                PageFactory.InitElements(Browser.Driver, personalSettingPage);
                return personalSettingPage;
            }
        }
        public static RegistrationPage RegistrationPage
        {
            get
            {
                var registrationPage = new RegistrationPage();
                PageFactory.InitElements(Browser.Driver, registrationPage);
                return registrationPage;
            }
        }
        public static ResetPasswordPage ResetPasswordPage
        {
            get
            {
                var resetPasswordPage = new ResetPasswordPage();
                PageFactory.InitElements(Browser.Driver, resetPasswordPage);
                return resetPasswordPage;
            }
        }
        public static FundamentalInformationPage FundamentalInformationPage
        {
            get
            {
                var fundamentalInformationPage = new FundamentalInformationPage();
                PageFactory.InitElements(Browser.Driver, fundamentalInformationPage);
                return fundamentalInformationPage;
            }
        }
        public static AvatarSettingPage AvatarSettingPage
        {
            get
            {
                var avatarSettingPage = new AvatarSettingPage();
                PageFactory.InitElements(Browser.Driver, avatarSettingPage);
                return avatarSettingPage;
            }
        }
        public static AdminFirstPage AdminFirstPage
        {
            get
            {
                var adminFirstPage = new AdminFirstPage();
                PageFactory.InitElements(Browser.Driver, adminFirstPage);
                return adminFirstPage;
            }
        }
        public static AdminManagementBackEndPage AdminManagementBackEndPage
        {
            get
            {
                var adminManagementBEPage = new AdminManagementBackEndPage();
                PageFactory.InitElements(Browser.Driver, adminManagementBEPage);
                return adminManagementBEPage;
            }
        }
        public static AdminCourseOrderPage AdminCourseOrderPage
        {
            get
            {
                var adminCourseOrderPage = new AdminCourseOrderPage();
                PageFactory.InitElements(Browser.Driver, adminCourseOrderPage);
                return adminCourseOrderPage;
            }
        }
        public static AdminClassOrderPage AdminClassOrderPage
        {
            get
            {
                var adminClassOrderPage = new AdminClassOrderPage();
                PageFactory.InitElements(Browser.Driver, adminClassOrderPage);
                return adminClassOrderPage;
            }
        }
    }
}
