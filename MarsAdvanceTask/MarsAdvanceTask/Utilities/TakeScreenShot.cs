using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsAdvanceTask.Utilities
{
    public class TakeScreenShot
    {
        public static void SSMethod(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Testing\sampletest\MarsAdvanceTask\MarsAdvanceTask\ScreenShot" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".Png", ScreenshotImageFormat.Png);

        }
    }
}