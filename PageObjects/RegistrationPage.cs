using LongRichAutomationUI.Common.Utilities;
using LongRichAutomationUI.Hooks;
using LongRichAutomationUI.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongRichAutomationUI.PageObjects
{
   public class RegistrationPage
    {

        public IWebDriver driver;



        
        
        Waits _wait;
        UIHelper helper;
        FileLocations _fileLocations;
        //ElementActions _elementActions;

        public RegistrationPage()
        {
            driver = BaseTest.driver;
            
            _wait = new Waits();
            helper = new UIHelper();
            _fileLocations = new FileLocations();
            //_elementActions = new ElementActions();
           //
           //PageFactory.InitElements(BaseTest.driver, this);
        }
        private By countryFlag = By.CssSelector("#swal2-content > ul > li.toplang-item.active > a > img");
        private By okay = By.CssSelector("body > div.swal2-container.swal2-center.swal2-backdrop-show > div > div.swal2-actions > button.swal2-confirm.swal2-styled");
        private By register = By.CssSelector("#header > div.site-header-wrapper > div.site-header-top-wrapper > div > div.site-header-row.site-header-top.d-flex.justify-content-between > div.site-header-top-right.d-flex > div:nth-child(4) > div:nth-child(2) > a > span");
        private By firstName = By.Id("firstname");
        private By lastName = By.Id("lastname");
        private By email = By.CssSelector("#emailaddressreg");
        private By phoneNumber = By.Id("telephone");
        private By password = By.CssSelector("#passwordreg");
        private By confirmPassword = By.CssSelector("#cnpassword");
        private By streetAddress = By.CssSelector("#address");
        private By townCity = By.CssSelector("#city");
        private By state = By.CssSelector("#state");
        private By createAccount = By.CssSelector("#btn_register");



        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickCountryFlag()
        {
            driver.FindElement(countryFlag).Click();
        }
        public void ClickOkay()
        {
            driver.FindElement(okay).Click();
        }
        public void ClickRegister()
        {
            driver.FindElement(register).Click();
        }

        public void EnterFirstName(string firstNametxt)
        {
            driver.FindElement(firstName).SendKeys(firstNametxt);
        }

        public void EnterLastName(string lastNametxt)
        {
            driver.FindElement(lastName).SendKeys(lastNametxt);
        }

        public void EnterEmail(string emailtxt)
        {
            driver.FindElement(email).SendKeys(emailtxt);
        }

        public void EnterPhoneNumber(string phoneNumbertxt)
        {
            driver.FindElement(phoneNumber).SendKeys(phoneNumbertxt);
        }

        public void EnterPassword(string passwordtxt)
        {
            driver.FindElement(email).SendKeys(passwordtxt);
        }

        public void EnterConfirmPassword(string confirmPasswordtxt)
        {
            driver.FindElement(confirmPassword).SendKeys(confirmPasswordtxt);
        }

        public void EnterStreetAddress(string streettxt)
        {
            driver.FindElement(streetAddress).SendKeys(streettxt);
        }

        public void EnterTownCity(string townCitytxt)
        {
            driver.FindElement(townCity).SendKeys(townCitytxt);
        }

        public void EnterState(string statetxt)
        {
            driver.FindElement(state).SendKeys(statetxt);
        }

        public void ClickCreateAccount()
        {
            driver.FindElement(createAccount).Click();
        }




    }
}
