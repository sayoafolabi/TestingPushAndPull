using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotraderBDDPageObjectModel.AutotraderPages
{
    public class AutotraderSearchResultPage : BaseClass
    {
        private IList<IWebElement> searchResult;

        public void ThenIAmOnSearchResultPage()
        {
            searchResult = GetElementsByClassName("search-result__title");
            Assert.True(searchResult.Count > 0, "No result is displayed");
        }

        public AutotraderResultPage AndIClickOnOneOfTheResultDisplayed()
        {
            Random ran = new Random();
            int randomNumber = ran.Next(1, 10);

            searchResult = GetElementsByClassName("gui-test-search-result-link");

            searchResult.ElementAt(randomNumber).Click();

            return new AutotraderResultPage();

        }

        public void ThenTheResultDisplayedOnSearchResultPageContains(string make)
        {
            searchResult = GetElementsByClassName("gui-test-search-result-link");

            foreach(var element in searchResult)
            {
                Assert.True(element.Text.ToLower().Contains(make.ToLower()), "No result is displayed");
            }
            
        }


    }
}
