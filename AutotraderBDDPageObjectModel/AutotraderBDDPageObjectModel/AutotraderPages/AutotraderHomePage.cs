using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotraderBDDPageObjectModel.AutotraderPages
{
    public class AutotraderHomePage : BaseClass
    {
        private IWebElement logo;
        private IWebElement postcode;
        private IWebElement distance;
        private IWebElement carMake;
        private IWebElement submitButton;

        public void AndIAmOnAutotraderHomepage()
        {
            logo = GetElementByClassName("site-header__logo");

            Assert.True(logo.Displayed, "Autotrader homepage not displayed");
        }

        public void WhenIEnterValidPostcode()
        {
            postcode = GetElementById("postcode");
            postcode.Clear();
            postcode.SendKeys("M34 5JD");
        }

        public void AndISelectDistanceToPostcode()
        {
            distance = GetElementById("radius");
            SelectByText(distance, "Within 55 miles");
        }

        public void AndISelectACarMake()
        {
            carMake = GetElementById("searchVehiclesMake");
            SelectByValue(carMake, "audi");
        }

        public void AndISelectACarMake(string make)
        {
            carMake = GetElementById("searchVehiclesMake");
            SelectByValue(carMake, make.ToLower());
        }

        public AutotraderSearchResultPage AndIClickOnSearchACarButton()
        {
            submitButton = GetElementById("search");
            submitButton.Click();

            return new AutotraderSearchResultPage();
        }
    }
}
