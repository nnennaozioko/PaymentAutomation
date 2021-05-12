using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using System.Linq;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;
using System.Collections.Generic;
using LongRichAutomationUI.Common.Utilities;
using System.IO;
using System.Reflection;

namespace LongRichAutomationUI.Hooks
{
    [Binding]
    public class BaseTest
    {
        static ScreenShots _screenShots;
        private static string[] featureTags;

        private static readonly List<string> _processesToCheck =
        new List<string>
        {
            "opera",
            "chrome",
            "firefox",
            "ie",
            "gecko",
            "phantomjs",
            "edge",
            "microsoftwebdriver",
            "webdriver"
        };

        public BaseTest()
        {
            _screenShots = new ScreenShots();

        }

        public static IWebDriver driver;

        [BeforeFeature]
        public static void BeforeFeature()
        {

            //{
                //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                //driver = new ChromeDriver(@"C:\Users\Nelly\source\repos\Longrich\LongRichAutomationUI\bin\Debug\netcoreapp3.1");
           // }

            try
            {
                featureTags = FeatureContext.Current.FeatureInfo.Tags;
                Process.GetProcessesByName("chromedriver").ToList().ForEach(p => p.Kill());
            }
            catch
            {
                System.Console.WriteLine("No browser to close");
            }

            OpenBrowser("Chrome");

        }

        private static void OpenBrowser(string browser)
        {
            ChromeOptions options = new ChromeOptions();
            

            //options.AddArguments("--headless");
            //options.AddArgument("--start-maximized");

            options.AddArguments("--disable-extensions");
            options.AddExcludedArgument("--ignore-certifcate-errors");
            options.AddArgument("--test-type");
            options.AddArgument("--incognito");
            options.AddArguments("--disable-notifications");
            options.AddArguments("--disable-popup-blocking");

            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);

           
            
        }



        [AfterScenario]
        public void AfterScenario()
        {
            try
            {
                if (ScenarioContext.Current.TestError != null)
                {
                    _screenShots.TakeTestScreenShot();
                }
            }
            catch (Exception e)
            {

            }
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            try
            {
                driver.Quit();
                driver.Dispose();
                Process.GetProcessesByName("chromedriver").ToList().ForEach(p => p.Kill());

                driver.Quit();
                BrowserProcesses.Kill("chrome");

                Process[] chromeInstances = Process.GetProcessesByName("chrome");

                CloseBrowsers(driver);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                CloseBrowsers(driver);
            }


        }

        public static void CloseBrowsers(IWebDriver driver)
        {

            driver?.Dispose();
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                try
                {
                    Debug.WriteLine(process.ProcessName);
                    //if (process.StartTime > TestRunStartTime)
                    {
                        var shouldKill = false;
                        foreach (var processName in _processesToCheck)
                        {
                            if (process.ProcessName.ToLower().Contains(processName))
                            {
                                shouldKill = true;
                                break;
                            }
                        }
                        if (shouldKill)
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }
    }
}
