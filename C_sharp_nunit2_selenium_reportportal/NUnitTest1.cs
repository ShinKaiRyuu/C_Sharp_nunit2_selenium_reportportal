using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ReportPortal.Shared;
using System;
using System.Drawing.Imaging;
using Selenium_nunit_C_Sharp.Helpers;

namespace Example.Tests
{
    [TestFixture]
    class Selenium_test
    {
        IWebDriver driver;
        Helper helper;
        

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            helper = new Helper();
        }

        [TearDown]
        public void EndTest()
        {
            var filePath = TestContext.CurrentContext.TestDirectory + "\\tmp.png";
            helper.TakeScreenshot(driver, filePath);
            //var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            //
            //screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Info, "screenshot {rp#file#" + filePath + "}");
            driver.Quit();
        }

        [Test]
        [Category("T1")]
        public void Test_1_Passed()
        {
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Trace, "This is message for test 1");
            driver.Url = "https://shinkairyuu.github.io/Selenium_test_page/";
            Assert.AreEqual("SELENIUM TEST PAGE INDEX", driver.Title);
        }

        [Test]
        public void Test_2_Failed()
        {
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Trace, "This is message for test 2");
            driver.Url = "https://shinkairyuu.github.io/Selenium_test_page/";
            Assert.AreEqual("SELENIUM TEST PAGE INDEX2", driver.Title);
        }

        [Test]
        [Ignore("Ignore a test")]
        public void Test_3_Ignored()
        {
            Bridge.LogMessage(ReportPortal.Client.Models.LogLevel.Trace, "This is message for test 2");
            driver.Url = "https://shinkairyuu.github.io/Selenium_test_page/";
            Assert.AreEqual("SELENIUM TEST PAGE INDEX", driver.Title);
        }
    }
}

