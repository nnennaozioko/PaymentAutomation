using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using LongRichAutomationUI.Hooks;

namespace LongRichAutomationUI.Common.Utilities
{
    class ElementActions
    {
        private Waits _wait;
        private object _elementActions;

        public ElementActions()
        {
            _wait = new Waits();
        }

        public void Click(string cssSelector)
        {
            IWebElement element = _wait.WaitForElement(cssSelector);
            //element.Click();

            try
            {
                if (!element.Enabled)
                    ScrollByVisibleElement(cssSelector);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //  element.Click();


            MoveToElementAndClick(cssSelector);

            //Thread.Sleep(5000);
            //_wait.WaitForElement(cssSelector).Click();

        }


        public void MoveToElementAndClick(string cssSelector)
        {
            _wait.WaitForElement(cssSelector);
            IWebElement element = BaseTest.driver.FindElement(By.CssSelector(cssSelector));
            Actions actions = new Actions(BaseTest.driver);
            actions.MoveToElement(element).Click().Build().Perform();
        }

        public void ScrollByVisibleElement(string cssSelector)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", (_wait.WaitForElement(cssSelector)));


        }
        //public void ScrollByPixel()
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
        //    js.ExecuteScript("window.scrollBy(x-pixels,y-pixels)");

        //}
        public IWebElement GetElement(string cssSelector)
        {
            return _wait.WaitForElement(cssSelector);

        }

        public string GetTextFromElement(string cssSelector)
        {
            return _wait.WaitForElement(cssSelector).Text;

        }

        public void Clear(string cssSelector)
        {
            IWebElement element = _wait.WaitForElement(cssSelector);

            element.Clear();

            // _wait.WaitForElement(cssSelector).Click();

        }

        public void ClickByPressingEnterKey(string cssSelector)
        {
            IWebElement element = _wait.WaitForElement(cssSelector);
            element.SendKeys(Keys.Enter);


        }

        public void SendKeys(string cssSelector, string textToEnter)
        {
            _wait.WaitForElement(cssSelector).SendKeys(textToEnter);
        }

        public void SelectFromDropDownByIndex(string cssSelector, int index)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(cssSelector));
            select.SelectByIndex(index);
        }

        public void SelectFromDropDownByText(string cssSelector, string text)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(cssSelector));
            select.SelectByText(text);
        }

        internal void SendKeys(string searchCommunity)
        {
            throw new NotImplementedException();
        }

        public void SelectFromDropDownByValue(string cssSelector, string value)
        {
            SelectElement select = new SelectElement(_wait.WaitForElement(cssSelector));
            select.SelectByValue(value);
        }

        public bool IsElementDisplayed(string cssSelector)
        {
            try
            {
                return _wait.WaitForElement(cssSelector).Displayed;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IList<IWebElement> GetListOfElements(string cssSelector)
        {
            return BaseTest.driver.FindElements(By.CssSelector(cssSelector));
        }



        public bool IsElementPresentInAList(string cssSelector, string text)
        {
            foreach (IWebElement element in GetListOfElements(cssSelector))
            {
                if (element.Text == text)
                    return true;
            }

            return false;
        }
    }
}
