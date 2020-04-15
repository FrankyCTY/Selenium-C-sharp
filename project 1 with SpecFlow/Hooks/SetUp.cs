using project_1_with_SpecFlow.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace project_1_with_SpecFlow.Hooks
{
    [Binding]
    public class SetUp
    {
        //Hooks
        [BeforeScenario]
        public void InitWebDriver()
        {
            Browser.InitDriver();
        }

    }
}
