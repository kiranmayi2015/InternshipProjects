using TechTalk.SpecFlow;

namespace MarsAdvanceTask.Utilities
{

    [Binding]
    public sealed class Driver : CommonDriver
    {
        [BeforeScenario]
        public void Setup()
        {
            LoginFunctions();

        }


        [AfterScenario]
        public void TearDown()
        {
            CloseTestRun();

        }
    }
}
