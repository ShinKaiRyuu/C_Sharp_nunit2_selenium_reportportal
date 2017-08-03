using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_nunit_C_Sharp.Helpers
{
    class Helper
    {
        public void TakeScreenshot(IWebDriver driver, String path)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            var filePath = path;
            screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
        }
    }
}
