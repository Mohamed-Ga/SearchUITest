using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SearchUITest
{
    [TestClass]
    public class SearchEngineTest
    {
        readonly ElementsLibrary _elements = new ElementsLibrary();
        readonly IWebDriver _driver = new ChromeDriver();

        [TestInitialize]
        public void TestInitialize()
        {
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://google.com";
        }

        [TestMethod]
        public void Search_Using_ValidName()
        {
            //Declare Needed Elements
            var searchBox = _driver.FindElement(By.XPath(_elements.googleSearchBox));
            string searchKeyWord = "Mercedes A Class";
            string resultKeyWord = "Top Gear";
            bool result = false;
            int counter = 1;

            //Execute Test Case
            searchBox.SendKeys(searchKeyWord);
            searchBox.SendKeys(Keys.Return);

            while (!result)
            {
                try
                {
                    result = _driver.FindElement(By.PartialLinkText(resultKeyWord)).Displayed;
                }
                catch (NoSuchElementException)
                {
                    var nextPage = _driver.FindElement(By.XPath(_elements.googleNextPageButton));
                    nextPage.Click();
                    counter++;
                    result = false;
                }
            }

            //Assert Get Result
            Assert.IsTrue(result);
            Console.WriteLine("The result keyword is available at page " + counter);
            _driver.Close();
        }
    }
}
