using LongRichAutomationUI.Hooks;
using LongRichAutomationUI.PageObjects;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace LongRichAutomationUI.Steps
{
    [Binding]
    public class PaymentSteps
    {

        public IWebDriver driver = BaseTest.driver;

        PaymentPage paymentPage = new PaymentPage();
        
        [Given(@"a registered user navigate to ""(.*)""")]
        public void GivenARegisteredUserNavigateTo(string url)
        {
            paymentPage.Navigate(url);
        }

        [When(@"a usre click country type")]
        public void WhenAUsreClickCountryType()

        {
            paymentPage.ClickCountryType();
        }

        [When(@"a user click Ok")]
        public void WhenAUserClickOk()
        {
            paymentPage.ClickOk();
        }

        [When(@"a user click sign in")]
        public void WhenAUserClickSignIn()

        {
            paymentPage.ClickSignIn();
        }

        [When(@"a user enter email ""(.*)""")]
        public void WhenAUserEnterEmail(string emailtxt)
        {
            //Thread.Sleep(5000); 
            paymentPage.EnterEmail(emailtxt);
        }

        [When(@"a user type password ""(.*)""")]
        public void WhenAUserTypePassword(string passwordtxt)
        {
            paymentPage.EnterPassword(passwordtxt);
        }

        [When(@"a user click login")]
        public void WhenAUserClickLogin()
        {
            paymentPage.ClickLogin();
        }
        //[When(@"a user navigate to ""(.*)""")]
        //public void WhenAUserNavigateTo(string url)
        //{
        //    driver.Navigate().GoToUrl(url);
        //}


        [When(@"a user click categories")]
        public void WhenAUserClickCategories()
        {
            paymentPage.ClickCategories();
        }

        [When(@"a userclick faminine care")]
        public void WhenAUserclickFaminineCare()
        {
            paymentPage.ClickFaminineCare();
        }


        //[When(@"a userclick product type")]
        //public void WhenAUserclickProductType()
        //{
        //    paymentPage.ClickProductType();
        //}


        [When(@"a user click featured Product")]
        public void WhenAUserClickFeaturedProduct()
        {
            paymentPage.ClickFeaturedProducts();
        }


        [When(@"a user enter quantity ""(.*)""")]
        public void WhenAUserEnterQuantity(string numbertxt)
        {
            paymentPage.EnterQuantity(numbertxt);
        }

        [When(@"a user click add to cart")]
        public void WhenAUserClickAddToCart()
        {
            paymentPage.ClickAddToCart();
        }

        //[When(@"a user click cart")]
        //public void WhenAUserClickCart()
        //{
        //    paymentPage.ClickAddToCart();
        //}

        //[When(@"a user click view cart")]
        //public void WhenAUserClickViewCart()
        //{
        //    paymentPage.ClickViewCart();
        //}

        //[When(@"a user click proceed checkout")]
        //public void WhenAUserClickProceedCheckout()
        //{
        //    //paymentPage.ClickProceedToCheckout(); 
        //}

        //[When(@"a user click pay stack")]
        //public void WhenAUserClickPayStack()
        //{
        //    paymentPage.ClickPayStack();
        //}


        //[When(@"a user click home delivery")]
        //public void WhenAUserClickHomeDelivery()
        //{
        //    paymentPage.ClickHomeDelivery();
        //}

        //[When(@"a user click existing address")]
        //public void WhenAUserClickExistingAddress()
        //{
        //    paymentPage.ClickExistingAdress();
        //}

        //[When(@"a user enter comment")]
        //public void WhenAUserEnterComment(string commenttxt)
        //{
        //    paymentPage.EnterComment(commenttxt); 
        //}

        //[When(@"a user click complete order")]
        //public void WhenAUserClickCompleteOrder()
        //{
        //    paymentPage.ClickCompleteOrder();
        //}

        //[When(@"a userclick on success card")]
        //public void WhenAUserclickOnSuccessCard()
        //{
        //    paymentPage.ClickSuccessCard();
        //}

        //[When(@"a user click pay")]
        //public void WhenAUserClickPay()
        //{
        //    paymentPage.ClickPay(); 
        //}

        //[Then(@"payment notification apperated ""(.*)""")]
        //public void ThenPaymentNotificationApperated(string p0)
        //{
        //    paymentPage.IsPaymentMadeSuccessfullyWithContains().Made().BeTrue();
        //}
    }
}


