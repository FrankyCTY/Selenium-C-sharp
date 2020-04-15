﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace project_1_with_SpecFlow.FeatureFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FundamentalInformation")]
    public partial class FundamentalInformationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FundamentalInformation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FundamentalInformation", "\tIn order to get people to know my basic information\r\n\tAs a user\r\n\tI want to be a" +
                    "ble to set up my fundamental information", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter too short name")]
        [NUnit.Framework.CategoryAttribute("Invalid_TooShortName")]
        [NUnit.Framework.TestCaseAttribute("a", null)]
        [NUnit.Framework.TestCaseAttribute("#", null)]
        [NUnit.Framework.TestCaseAttribute("嚴", null)]
        [NUnit.Framework.TestCaseAttribute("1", null)]
        public virtual void EnterTooShortName(string name, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Invalid_TooShortName"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter too short name", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table1.AddRow(new string[] {
                        "test001",
                        "Test1234"});
#line 8
 testRunner.Given("I am logged into my account", ((string)(null)), table1, "Given ");
#line 11
 testRunner.Given("I am on the fundamental information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.And(string.Format("I entered \"{0}\" less than 2 characters for the name", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When("I press save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("error msg 最少需要输入 2 个字符 should be shown under the name input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter too long name")]
        [NUnit.Framework.CategoryAttribute("Invalid_TooLongName")]
        [NUnit.Framework.TestCaseAttribute("aaaaaaaaaaaaaaaaaaa", null)]
        [NUnit.Framework.TestCaseAttribute("###################", null)]
        [NUnit.Framework.TestCaseAttribute("嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴", null)]
        [NUnit.Framework.TestCaseAttribute("1111111111111111111", null)]
        public virtual void EnterTooLongName(string name, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Invalid_TooLongName"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter too long name", @__tags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table2.AddRow(new string[] {
                        "test001",
                        "Test1234"});
#line 25
 testRunner.Given("I am logged into my account", ((string)(null)), table2, "Given ");
#line 28
 testRunner.Given("I am on the fundamental information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.And(string.Format("I entered \"{0}\" more than 18 characters for the name", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I press save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("error msg 最多只能输入 18 个字符 should be shown under the name input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter invalid ID number")]
        [NUnit.Framework.CategoryAttribute("Invalid_IdNumber")]
        [NUnit.Framework.TestCaseAttribute("aaaaaaaaaaaaaaaaaaa", null)]
        [NUnit.Framework.TestCaseAttribute("###################", null)]
        [NUnit.Framework.TestCaseAttribute("嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴", null)]
        [NUnit.Framework.TestCaseAttribute("1111111111111111111", null)]
        public virtual void EnterInvalidIDNumber(string iDNumber, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Invalid_IdNumber"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter invalid ID number", @__tags);
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table3.AddRow(new string[] {
                        "test001",
                        "Test1234"});
#line 42
 testRunner.Given("I am logged into my account", ((string)(null)), table3, "Given ");
#line 45
 testRunner.Given("I am on the fundamental information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.And(string.Format("I entered \"{0}\" invalid ID number", iDNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("I press save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("error msg 请正确输入您的身份证号码 should be shown under the ID number input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter invalid Phone Number")]
        [NUnit.Framework.CategoryAttribute("Invalid_PhoneNumber")]
        [NUnit.Framework.TestCaseAttribute("aaaaaaaaaaaaaaaaaaa", null)]
        [NUnit.Framework.TestCaseAttribute("###################", null)]
        [NUnit.Framework.TestCaseAttribute("嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴", null)]
        [NUnit.Framework.TestCaseAttribute("1111111111111111111", null)]
        public virtual void EnterInvalidPhoneNumber(string phoneNumber, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Invalid_PhoneNumber"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter invalid Phone Number", @__tags);
#line 58
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table4.AddRow(new string[] {
                        "test001",
                        "Test1234"});
#line 59
 testRunner.Given("I am logged into my account", ((string)(null)), table4, "Given ");
#line 62
 testRunner.Given("I am on the fundamental information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
 testRunner.And(string.Format("I entered \"{0}\" invalid phone number", phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.When("I press save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
 testRunner.Then("error msg 请输入正确的手机号 should be shown under the phone number input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter too long title")]
        [NUnit.Framework.CategoryAttribute("Invalid_TooLongTitle")]
        [NUnit.Framework.TestCaseAttribute("aaaaaaaaaaaaaaaaaaaaaaaaa", null)]
        [NUnit.Framework.TestCaseAttribute("#########################", null)]
        [NUnit.Framework.TestCaseAttribute("嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴", null)]
        [NUnit.Framework.TestCaseAttribute("1111111111111111111111111", null)]
        public virtual void EnterTooLongTitle(string title, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Invalid_TooLongTitle"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter too long title", @__tags);
#line 75
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table5.AddRow(new string[] {
                        "test001",
                        "Test1234"});
#line 76
 testRunner.Given("I am logged into my account", ((string)(null)), table5, "Given ");
#line 79
 testRunner.Given("I am on the fundamental information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
 testRunner.And(string.Format("I entered \"{0}\" too long title", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.When("I press save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then("error msg 最多只能输入 24 个字符 should be shown under the title input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter invalid site")]
        [NUnit.Framework.CategoryAttribute("Invalid_InvalidSite")]
        [NUnit.Framework.TestCaseAttribute("htt://aaaaaaaaaaaaaaaaaaaaaaaaa", null)]
        [NUnit.Framework.TestCaseAttribute("#########################", null)]
        [NUnit.Framework.TestCaseAttribute("嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴", null)]
        [NUnit.Framework.TestCaseAttribute("1111111111111111111111111", null)]
        public virtual void EnterInvalidSite(string site, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Invalid_InvalidSite"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter invalid site", @__tags);
#line 92
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table6.AddRow(new string[] {
                        "test001",
                        "Test1234"});
#line 93
 testRunner.Given("I am logged into my account", ((string)(null)), table6, "Given ");
#line 96
 testRunner.Given("I am on the fundamental information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
 testRunner.And(string.Format("I entered \"{0}\" invalid site", site), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.When("I press save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("error msg 地址不正确，须以http://或者https://开头。 should be shown under the site input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter invalid weibo")]
        [NUnit.Framework.CategoryAttribute("Invalid_InvalidWeibo")]
        [NUnit.Framework.TestCaseAttribute("htt://aaaaaaaaaaaaaaaaaaaaaaaaa", null)]
        [NUnit.Framework.TestCaseAttribute("#########################", null)]
        [NUnit.Framework.TestCaseAttribute("嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴", null)]
        [NUnit.Framework.TestCaseAttribute("1111111111111111111111111", null)]
        public virtual void EnterInvalidWeibo(string weibo, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Invalid_InvalidWeibo"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter invalid weibo", @__tags);
#line 109
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table7.AddRow(new string[] {
                        "test001",
                        "Test1234"});
#line 110
 testRunner.Given("I am logged into my account", ((string)(null)), table7, "Given ");
#line 113
 testRunner.Given("I am on the fundamental information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 114
 testRunner.And(string.Format("I entered \"{0}\" invalid weibo", weibo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.When("I press save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 116
 testRunner.Then("error msg 地址不正确，须以http://或者https://开头。 should be shown under the weibo input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Enter invalid QQ")]
        [NUnit.Framework.CategoryAttribute("Invalid_InvalidQQ")]
        [NUnit.Framework.TestCaseAttribute("htt://aaaaaaaaaaaaaaaaaaaaaaaaa", null)]
        [NUnit.Framework.TestCaseAttribute("astdgherheh#", null)]
        [NUnit.Framework.TestCaseAttribute("嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴嚴", null)]
        public virtual void EnterInvalidQQ(string qQ, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Invalid_InvalidQQ"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Enter invalid QQ", @__tags);
#line 126
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Username",
                        "Password"});
            table8.AddRow(new string[] {
                        "test001",
                        "Test1234"});
#line 127
 testRunner.Given("I am logged into my account", ((string)(null)), table8, "Given ");
#line 130
 testRunner.Given("I am on the fundamental information page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 131
 testRunner.And(string.Format("I entered \"{0}\" invalid QQ", qQ), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.When("I press save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.Then("error msg 请输入正确的QQ号 should be shown under the QQ input", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion