using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Training_5.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            
            Driver = new ChromeDriver();
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
