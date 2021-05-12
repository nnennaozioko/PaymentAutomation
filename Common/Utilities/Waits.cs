using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using LongRichAutomationUI.Hooks;

namespace LongRichAutomationUI.Common.Utilities
{
    class Waits
    {
        /// <summary>
        /// Waits for WebElement to be displayed
        /// </summary>
        /// <param name="element">The WebElement to check if it is displayed</param>
        /// <returns>The WebElement that is displayed</returns>
        public IWebElement WaitForElement(string elementCSS)
        {
            IWebElement elementFound = null;

            for (var i = 0; i < 2; i++)
            {

                try
                {
                    WebDriverWait fluentWait = new WebDriverWait(BaseTest.driver, TimeSpan.FromSeconds(5));

                    fluentWait.Timeout = TimeSpan.FromSeconds(10);
                    fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
                    fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                    elementFound = fluentWait.Until(x => BaseTest.driver.FindElement(By.CssSelector(elementCSS)));
                    if (elementFound.Enabled)
                        break;
                }
                catch
                {

                }


            }

            return elementFound;

        }


        public IWebElement WaitForElement(IWebElement element)
        {
            for (var i = 0; i < 3; i++)
            {

                try
                {
                    DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(BaseTest.driver);

                    fluentWait.Timeout = TimeSpan.FromSeconds(5);
                    fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
                    fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                    if (fluentWait.Until(x => element.Enabled))
                        return element;
                }
                catch
                {

                }

            }

            return null;

        }


    }
}
