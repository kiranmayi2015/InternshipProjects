using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Firstscript.Pages;
using Firstscript.Utilities;

namespace Firstscript.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_tests : CommonDriver
    {
        
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();



        [Test, Order(1), Description("This test creates a new TM record")]

        public void CreateTMTest()
        {

            homePageObj.GoToTMPage(driver);
            tmPageObj.CreateTM(driver);
        }

        [Test, Order(2), Description("This test edits a TM record")]

        public void EditTMTest()
        {
            homePageObj.GoToTMPage(driver);
            
            //tmPageObj.EditTM(driver);
        }
        [Test, Order(3), Description("This test deletes a TM record")]

        public void DeleteTMTest()
        {
            homePageObj.GoToTMPage(driver);
            tmPageObj.DeleteTM(driver);
        }

    }
}
