using PythonpageOperations.Specs.Drivers;
using FluentAssertions;
using TechTalk.SpecFlow;
using PythonpageOperations.Specs.PageObjects;
using System;

namespace PythonpageOperations.Specs.Steps
{
    [Binding]
    public sealed class PythonSuccessStory
    {
      
        private readonly PythonLandingPage _pythonLandingPageObject;
        private ArtsPage _artspg;
        private int rand_num;

        public PythonSuccessStory(BrowserDriver browserDriver)
        {
            _pythonLandingPageObject = new PythonLandingPage(browserDriver.Current);
            Random rd = new Random();

             rand_num = rd.Next(100, 200);

        }

        [Given(@"The url of python webpage '(.*)'")]
        public void GivenTheUrlOfPythonWebpage(string url)
        {
            _pythonLandingPageObject.navigateURL(url);
        }

        [Given(@"Go to successstories and arts")]
        public void GivenGoToSuccessstoriesAndArts()
        {
            _artspg = _pythonLandingPageObject.Hoverover_success_storyandclickonArts();
        }


        [Given(@"go to Submit yours")]
        public void GivenGoToSubmitYours()
        {
            _artspg.Submit();
        }

        [When(@"All data entered as '(.*)' ,'(.*)', '(.*)','(.*)','(.*)','(.*)','(.*)','(.*)'")]
        public void WhenAllDataEnteredAs(string storyName, string companyName, string companyUrl, string category, string author, string author_email, string quote, string content)
        {
            _artspg.enterStoryName(storyName+rand_num);
            _artspg.enterCompanyName(companyName);
            _artspg.enterCompanyURL(companyUrl);
            _artspg.selectCategory(category);
            _artspg.enterauthor(author);
            _artspg.enterauthorEmail(author_email);
            _artspg.enterquote(quote);
            _artspg.enterContent(content);
            _artspg.submitWholeForm();
            
        }
        [Then(@"one message should show up '(.*)'")]
        public void ThenOneMessageShouldShowUp(string success_message)
        {
            _artspg.getmessage().Should().Be(success_message);
        }



    }
}