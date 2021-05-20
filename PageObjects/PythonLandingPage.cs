using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PythonpageOperations.Specs.PageObjects
{
    public class PythonLandingPage
    {
        private readonly IWebDriver _webDriver;
        private readonly Actions action;
        public PythonLandingPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            action = new Actions(_webDriver);

        }

        private IWebElement successstory_ID => _webDriver.FindElement(By.Id("success-stories"));
        private IWebElement arts_ID => _webDriver.FindElement(By.XPath("//li[@id='success-stories']/ul/li/a[text()='Arts']"));

        public void navigateURL(String url) => _webDriver.Navigate().GoToUrl(url);
        public ArtsPage Hoverover_success_storyandclickonArts()
        {
            Actions act = action.MoveToElement(successstory_ID);
            act.Build().Perform();
            act.MoveToElement(arts_ID).Click().Build().Perform();
            return new ArtsPage(_webDriver);
        }

    }
}
