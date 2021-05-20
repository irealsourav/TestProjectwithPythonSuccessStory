using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PythonpageOperations.Specs.PageObjects
{
    public class ArtsPage
    {
        private readonly IWebDriver _webDriver;
        private readonly Actions action;
        private readonly WebDriverWait wait;
        public ArtsPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            action = new Actions(_webDriver);
            wait = new WebDriverWait(_webDriver, new TimeSpan(0, 0, 5));
        }
        private IWebElement artsValue => _webDriver.FindElement(By.XPath("//h1[text()='Arts']"));
        private IWebElement submit => _webDriver.FindElement(By.XPath("//strong[text()='Submit Yours!']"));
        private IWebElement category => _webDriver.FindElement(By.Id("id_category"));
        private IWebElement storyName => _webDriver.FindElement(By.Id("id_name"));
        private IWebElement companyName => _webDriver.FindElement(By.Id("id_company_name"));
        private IWebElement companyUrl => _webDriver.FindElement(By.Id("id_company_url"));
        private IWebElement author => _webDriver.FindElement(By.Id("id_author"));
        private IWebElement author_email => _webDriver.FindElement(By.Id("id_author_email"));
        private IWebElement pull_quote => _webDriver.FindElement(By.Id("id_pull_quote"));

        private IWebElement content => _webDriver.FindElement(By.Id("id_content"));

        private IWebElement submitForm => _webDriver.FindElement(By.Name("Submit"));
        private IWebElement successMsg => _webDriver.FindElement(By.XPath("//p[@role='success']"));

        public String ArtsVal()
        {
            return artsValue.Text;
        }
        public void Submit()
        {
            submit.Click();
        }

        public void enterStoryName(String Text)
        {
            storyName.Clear();
            storyName.SendKeys(Text);
        }

        public void enterCompanyName(String Text)
        {
            companyName.Clear();
            companyName.SendKeys(Text);
        }

        public void selectCategory(String text)
        {
            new SelectElement(category).SelectByText(text);
        }

        public void enterCompanyURL(String Text)
        {
            companyUrl.Clear();
            companyUrl.SendKeys(Text);
        }

        public void enterauthor(String Text)
        {
            author.Clear();
            author.SendKeys(Text);
        }
        public void enterauthorEmail(String Text)
        {
            author_email.Clear();
            author_email.SendKeys(Text);
        }
        public void enterquote(String Text)
        {
            pull_quote.Clear();
            pull_quote.SendKeys(Text);
        }
        public void enterContent(String Text)
        {
            content.Clear();
            content.SendKeys(Text);
        }
        public void submitWholeForm()
        {
            submitForm.Click();
        }
        public String getmessage()
        {
            return successMsg.Text;
        }




    }
}
