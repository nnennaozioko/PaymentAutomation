using LongRichAutomationUI.Common.Utilities;
using LongRichAutomationUI.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongRichAutomationUI.PageObjects
{
    class PaymentPage
    {
        public IWebDriver driver; 

        
        public PaymentPage()
        {                               
            driver = BaseTest.driver;

            
        }

        private By countryType = By.CssSelector("#swal2-content > ul > li:nth-child(1) > a > img");
        private By ok = By.CssSelector("body > div.swal2-container.swal2-center.swal2-backdrop-show > div > div.swal2-actions > button.swal2-confirm.swal2-styled");
        private By signIn = By.CssSelector("#header > div.site-header-wrapper > div.site-header-top-wrapper > div > div.site-header-row.site-header-top.d-flex.justify-content-between > div.site-header-top-right.d-flex > div:nth-child(4) > div:nth-child(1) > a > span");
        private By email = By.CssSelector("#emailaddress");
        private By password = By.CssSelector("#password");
        private By login = By.CssSelector("#btn_login");
        private By categories = By.CssSelector("#menu-main-menu > li:nth-child(2) > a");
        private By faminineCare = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(2) > a");
        //private By productType = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(2) > a");
        private By featuredProducts = By.CssSelector(" div:nth-child(2) > div > div > div > div.product-image3 > a > img.pic-2");
        private By quantity = By.CssSelector(" form > div > div.variations_button > div");
        private By addToCart = By.CssSelector(" div.variations_button > button");
        private By cart = By.CssSelector("div.site-header-main-right.d-flex.justify-content-end.align-items-center");
        private By viewCart = By.CssSelector("#cart_area > div > div > div > p.buttons > a.button.checkout.wc-forward");
        private By proceedToCheckout = By.CssSelector("#content > div > div > div.right_sidebar.col-sm-12.col-md-12.col-lg-9.mb-md-50 > div.text_box > div > div > div > div > a");
       // private By payStack = By.CssSelector("#paystack");
       // private By homeDelivery = By.CssSelector("#shipping_home");
       //// private By existingAddress = By.CssSelector("");
       // private By comment = By.CssSelector("#custom_field");
       // private By completeOrder = By.CssSelector("#btn_order");
       // private By successCard = By.CssSelector("#test-cards > div.cards > div:nth-child(1) > div > div.card__details__select > div");
       // private By pay = By.CssSelector("#test-cards > button");
       // private By paymentMadeSuccessfully = By.CssSelector("#dialoguetext");


        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickCountryType()
        {
            driver.FindElement(countryType).Click();
        }

        public void ClickOk()
        {
            driver.FindElement(ok).Click();
        }

        public void ClickSignIn()
        {
            driver.FindElement(signIn).Click();
        }

        public void EnterEmail(string emailtxt)
        {
            driver.FindElement(email).SendKeys(emailtxt);
        }

        public void EnterPassword(string passwordtxt)
        {
            driver.FindElement(password).SendKeys(passwordtxt);
        }

        public void ClickLogin()
        {
            driver.FindElement(login).Click();
        }

        public void ClickCategories()
        {
            driver.FindElement(categories).Click();
        }
        public void ClickFaminineCare()
        {
            driver.FindElement(faminineCare).Click();
        }

        //public void ClickProductType()
        //{
        //    driver.FindElement(productType).Click();
        //}

        public void ClickFeaturedProducts()
        {
            driver.FindElement(featuredProducts).Click();
        }

        public void EnterQuantity(string numbertxt)
        {
            driver.FindElement(quantity).SendKeys(numbertxt);
        }

        public void ClickAddToCart()
        {
            driver.FindElement(addToCart);
        }

        //public void ClickCart()
        //{
        //    driver.FindElement(cart).Click();
        //}

        //public void ClickViewCart()
        //{
        //    driver.FindElement(viewCart).Click();
        //}

        //public void ClickProceedToCheckout()
        //{
        //    driver.FindElement(proceedToCheckout).Click();
        //}

        //public void ClickPayStack()
        //{
        //    driver.FindElement(payStack).Click();
        //}

        //public void ClickHomeDelivery()
        //
        //    driver.FindElement(homeDelivery).Click(); 
        //}

        //public void ClickExistingAdress()
        //{
        //    driver.FindElement(exixtingAddress).Click();
        //}

        //public void EnterComment(string commenttxt)
        //{
        //    driver.FindElement(comment).SendKeys(commenttxt);
        //}

        //public void ClickCompleteOrder()
        //{
        //    driver.FindElement(completeOrder).Click();
        //}

        //public void ClickSuccessCard()
        //{
        //    driver.FindElement(successCard).Click();
        //}

        //public void ClickPay()
        //{
        //    driver.FindElement(pay).Click();
        //}

        //public bool IsPaymentMadeSuccessfullyWithContains()
        //{
        //    return driver.FindElement(paymentMadeSuccessfully).Text.Contains("payment made successfully");
        //}


















    }
}
