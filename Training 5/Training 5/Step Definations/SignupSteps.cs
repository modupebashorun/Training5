using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Training_5.Page_Objects;
using Training_5.Utilities;

namespace Training_5.Step_Definations
{
    [Binding]
    public class SignupSteps
    {
        SignupPage signup;

        public SignupSteps()
        {
            signup = new SignupPage();
        }
        [Given(@"I am not logged in")]
        public void GivenIAmNotLoggedIn()
        {

            Hooks.Driver.Navigate().GoToUrl("https://angularjs.realworld.io");
            Hooks.Driver.Manage().Window.Maximize();
        }

        [When(@"I complete the sign up form")]
        public void WhenICompleteTheSignUpForm()
        {
            signup.CompleteTheSignUpForm();

        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            Assert.IsTrue(signup.LoggedInIsDisplayed());
        }

        [Then(@"my username is displayed")]
        public void ThenMyUsernameIsDisplayed()
        {
            Thread.Sleep(10000);
            Assert.IsTrue(signup.ConfirmuserIsDisplayed());
        }
    }
}