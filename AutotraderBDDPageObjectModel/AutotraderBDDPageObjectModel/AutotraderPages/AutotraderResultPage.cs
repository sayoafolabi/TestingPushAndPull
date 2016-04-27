﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotraderBDDPageObjectModel.AutotraderPages
{
    public class AutotraderResultPage : BaseClass
    {

        private IWebElement quote;

        public void AndIAmOnResultPageForTheCar()
        {
            quote = GetElementByClassName("insurance-quote");
            Assert.True(quote.Displayed, "Result page is not displayed");
        }
    }
}
