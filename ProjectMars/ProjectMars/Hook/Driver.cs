using ProjectMars.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProjectMars.Hook
{
    [Binding]
    public sealed class Driver : CommonDriver
    {
        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();

        }


        [AfterScenario]
        public void TearDown()
        {
            CloseTestRun();

        }
    }
}

