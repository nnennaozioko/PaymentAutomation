using LongRichAutomationUI.Hooks;
using LongRichAutomationUI.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace LongRichAutomationUI.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        public IWebDriver driver = BaseTest.driver;

        RegistrationPage registrationPage = new RegistrationPage();
               
                
        [Given(@"a user navigate to ""(.*)""")]
        public void GivenAUserNavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        [When(@"a user click country type")]
        public void WhenAUserClickCountryType()
        {
            registrationPage.ClickCountryFlag();
        }

        [When(@"a user click okay to select country type")]
        public void WhenAUserClickOkayToSelectCountryType()
        {
            registrationPage.ClickOkay();
        }


        [When(@"a user click on Register")]
        public void WhenAUserClickOnRegister()
        {
            registrationPage.ClickRegister();
        }
        
        [When(@"a user enter first name ""(.*)""")]
        public void WhenAUserEnterFirstName(string firstNametxt)
        {
            registrationPage.EnterFirstName(firstNametxt);
        }
        
        [When(@"a user enter last name ""(.*)""")]
        public void WhenAUserEnterLastName(string lastNametxt)
        {
            registrationPage.EnterLastName(lastNametxt);
        }
        
        [When(@"a user enter email address ""(.*)""")]
        public void WhenAUserEnterEmailAddress(string emailtxt)
        {
            registrationPage.EnterEmail(emailtxt);
        }
        
        [When(@"a user enter phone number ""(.*)""")]
        public void WhenAUserEnterPhoneNumber(string phoneNumbertxt)
        {
            registrationPage.EnterPhoneNumber(phoneNumbertxt);
        }
        
        [When(@"a user enter password ""(.*)""")]
        public void WhenAUserEnterPassword(string passwordtxt)
        {
            registrationPage.EnterPassword(passwordtxt);
        }
        
        [When(@"a user enter confirm password ""(.*)""")]
        public void WhenAUserEnterConfirmPassword(string confirmPasswordtxt)
        {
            registrationPage.EnterConfirmPassword(confirmPasswordtxt);
        }
        
        [When(@"a user enter street address ""(.*)""")]
        public void WhenAUserEnterStreetAddress(string streettxt)
        {
            registrationPage.EnterStreetAddress(streettxt);
        }
        
        [When(@"a user enter Town/City ""(.*)""")]
        public void WhenAUserEnterTownCity(string townCitytxt)
        {
            registrationPage.EnterTownCity(townCitytxt);
        }
        
        [When(@"a user enter state ""(.*)""")]
        public void WhenAUserEnterState(string statetxt)
        {
            registrationPage.EnterState(statetxt);
        }
        
        [When(@"a user click create account")]
        public void WhenAUserClickCreateAccount()
        {
            registrationPage.ClickCreateAccount();
        }

        [Then(@"success notification '(.*)'")]
        public void ThenSuccessNotification(string p0)
        {
            
        }

        [Then(@"error message displayed")]
        public void ThenErrorMessageDisplayed()
        {

        }
        [Then(@"error notification '(.*)'")]
        public void ThenErrorNotification(string p0)
        {
           
        }

        [Then(@"error message first name is required'")]
        public void ThenErrorMessageFirstNameIsRequired()
        {
           
        }














    }
}
