using AutotraderBDDPageObjectModel.AutotraderPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutotraderBDDPageObjectModel.Steps
{
    [Binding]
    public class SearchSteps
    {
        private AutotraderHomePage homepage;
        private AutotraderSearchResultPage searchResultPage;
        private AutotraderResultPage resultPage;

        [Given(@"I navigate to Autotrader website")]
        public void GivenINavigateToAutotraderWebsite()
        {
            homepage = BaseClass.GivenINavigateAutotraderHomepage();
            homepage.AndIAmOnAutotraderHomepage();
        }

        [When(@"search for a car type")]
        public void WhenSearchForACarType()
        {
            homepage.WhenIEnterValidPostcode();
            homepage.AndISelectDistanceToPostcode();
            homepage.AndISelectACarMake();
            searchResultPage = homepage.AndIClickOnSearchACarButton();
        }

        [Then(@"the result is displayed")]
        public void ThenTheResultIsDisplayed()
        {
            searchResultPage.ThenIAmOnSearchResultPage();
        }

        [Then(@"I can view a selected car")]
        public void ThenICanViewASelectedCar()
        {
            resultPage = searchResultPage.AndIClickOnOneOfTheResultDisplayed();
            resultPage.AndIAmOnResultPageForTheCar();
        }

        [When(@"search for a ""(.*)""")]
        public void WhenSearchForA(string make)
        {
            homepage.WhenIEnterValidPostcode();
            homepage.AndISelectDistanceToPostcode();
            homepage.AndISelectACarMake(make);
            searchResultPage = homepage.AndIClickOnSearchACarButton();
        }

        [Then(@"the result for ""(.*)"" is displayed")]
        public void ThenTheResultForIsDisplayed(string make)
        {
            searchResultPage.ThenTheResultDisplayedOnSearchResultPageContains(make);
        }



    }
}
