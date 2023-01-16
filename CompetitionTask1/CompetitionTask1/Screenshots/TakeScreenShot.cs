﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTask1.Screenshots
{
    public class TakeScreenShot
    {
        public static void SSMethod(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Testing\sampletest\CompetitionTask1\CompetitionTask1\ScreenShot" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".Png", ScreenshotImageFormat.Png);

        }
    }
}
