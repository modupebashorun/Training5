using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training_5.Utilities;

namespace Training_5.Page_Objects
{
    public class SignupPage
    {
        public SignupPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Sign up")]
        private IWebElement Signup { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @placeholder='Username']")]
        private IWebElement Username { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='email' and @placeholder='Email']")]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='password' and @placeholder='Password']")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn")]
        private IWebElement signup { get; set; }

        public void CompleteTheSignUpForm()
        {
            Signup.Click();
            Username.SendKeys("Modupe");
            Email.SendKeys("modupebashorun@yahoo.co.uk");
            Password.SendKeys("Jawdan21");
            signup.Click();
        }


        [FindsBy(How = How.LinkText, Using = "conduit")]
        private IWebElement loggedin { get; set; }

        public bool LoggedInIsDisplayed()
        {

            {
                return loggedin.Displayed;
            }

        }


        [FindsBy(How = How.CssSelector, Using = "li.nav-item:nth-child(4) > a:nth-child(1)")]
        private IWebElement username { get; set; }

        public bool ConfirmuserIsDisplayed()
        {

            {
                return username.Displayed;
            }











        }

    }
}