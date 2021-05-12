using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.IO;
using TechTalk.SpecFlow;
using LongRichAutomationUI.Hooks;

namespace LongRichAutomationUI.Common.Utilities
{
    public class ScreenShots
    {
        FileLocations _fileLocations;

        public ScreenShots()
        {
            _fileLocations = new FileLocations();
        }

        public void TakeTestScreenShot()
        {

            try
            {
                string screenShotImagesFolder = _fileLocations.GetFolderLocation("ScreenShotImages");

                string fileNameBase =
                     $"{DateTime.Now:yyyyMMdd_HHmmss}_error_FEATURE_{FeatureContext.Current.FeatureInfo.Title}_SCENARIO_{ScenarioContext.Current.ScenarioInfo.Title}";

                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    fileNameBase = fileNameBase.Replace(c, '_');
                }

                fileNameBase = fileNameBase.Replace(" ", "_");
                fileNameBase = fileNameBase.Replace(" ", "_");
                fileNameBase = fileNameBase.Replace("-", "_");

                if (fileNameBase.Length > 100)
                    fileNameBase = fileNameBase.Substring(0, 100);

                string screenshotFilePath = Path.Combine(screenShotImagesFolder + fileNameBase + "_screenshot.png");
                Console.WriteLine("ERROR LOG:Filename: {0}", fileNameBase);


                if (BaseTest.driver is ITakesScreenshot takesScreenshot)
                {
                    var screenshot = takesScreenshot.GetScreenshot();
                    screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
                    //Console.WriteLine("ERROR LOG: Screenshot: {0}", new Uri(screenshotFilePath));
                    Console.WriteLine("ERROR LOG:Click here to view Screenshot on server: {0}", new Uri(screenshotFilePath));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }


        }

    }
}
