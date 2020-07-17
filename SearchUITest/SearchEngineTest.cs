using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
            _driver.Url = "https://yts.mx/browse-movies";
        }

        [TestMethod]
        public void Search_NoData()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Execute Test Case
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000); 
            var newSearchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Validate Result and Close The Browser
            Assert.AreEqual(searchResult, newSearchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidName()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var searchBox = _driver.FindElement(By.XPath(_elements.searchBox));
            string movieName = "About Time";

            //Execute Test Case
            searchBox.SendKeys(movieName);
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;
            var movie = _driver.FindElement(By.LinkText("About Time")).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            Assert.AreEqual(movieName, movie);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_PercentageSign()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var searchBox = _driver.FindElement(By.XPath(_elements.searchBox));
            string movieName = "About Time%";

            //Execute Test Case
            searchBox.SendKeys(movieName);
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;
            var movie = _driver.FindElement(By.LinkText("About Time")).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            Assert.AreEqual(movieName, movie);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidName_PressingEnter()
        {
            //Declare Needed Elements
            var searchBox = _driver.FindElement(By.XPath(_elements.searchBox));
            string movieName = "About Time";

            //Execute Test Case
            searchBox.SendKeys(movieName);
            searchBox.SendKeys(Keys.Enter);

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;
            var movie = _driver.FindElement(By.LinkText("About Time")).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            Assert.AreEqual(movieName, movie);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_InvalidName()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var searchBox = _driver.FindElement(By.XPath(_elements.searchBox));
            string movieName = "!@#$";

            //Execute Test Case
            searchBox.SendKeys(movieName);
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Validate Result and Close The Browser
            Assert.AreEqual("0", searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidQuality()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var qualityList = _driver.FindElement(By.XPath(_elements.quality));
            var selectElement = new SelectElement(qualityList);

            //Execute Test Case
            selectElement.SelectByValue("720p");
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidRating()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var ratingList = _driver.FindElement(By.XPath(_elements.rating));
            var selectElement = new SelectElement(ratingList);

            //Execute Test Case
            selectElement.SelectByValue("8");
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;
            
            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidGenre()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var genreList = _driver.FindElement(By.XPath(_elements.genre));
            var selectElement = new SelectElement(genreList);

            //Execute Test Case
            selectElement.SelectByValue("action");
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidYear()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var yearList = _driver.FindElement(By.XPath(_elements.year));
            var selectElement = new SelectElement(yearList);
            string searchYear = "2020";

            //Execute Test Case
            selectElement.SelectByValue(searchYear);
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;
            var year = _driver.FindElement(By.ClassName("browse-movie-year")).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            Assert.AreEqual(searchYear, year);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidLanguage()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var languageList = _driver.FindElement(By.XPath(_elements.language));
            var selectElement = new SelectElement(languageList);

            //Execute Test Case
            selectElement.SelectByValue("en");
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidOrder()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var orderList = _driver.FindElement(By.XPath(_elements.order));
            var selectElement = new SelectElement(orderList);

            //Execute Test Case
            selectElement.SelectByValue("latest");
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_QuickSearch()
        {
            //Declare Needed Elements
            var quickSearch = _driver.FindElement(By.XPath(_elements.quickSearch));

            //Execute Test Case
            quickSearch.SendKeys("Abo");
            Thread.Sleep(1000);
            var firstChoice = _driver.FindElement(By.XPath(_elements.firstChoice));
            firstChoice.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.downloadButton)).Displayed;

            //Validate Result and Close The Browser
            Assert.IsTrue(searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_DifferentCriteria()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var yearList = _driver.FindElement(By.XPath(_elements.year));
            var yearDropDown = new SelectElement(yearList);
            var genreList = _driver.FindElement(By.XPath(_elements.genre));
            var genreDropDown = new SelectElement(genreList);
            var ratingList = _driver.FindElement(By.XPath(_elements.rating));
            var ratingDropDown = new SelectElement(ratingList);

            //Execute Test Case
            yearDropDown.SelectByValue("2020");
            genreDropDown.SelectByValue("action");
            ratingDropDown.SelectByValue("8");
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ValidGenre_GoThroughMultiplePages()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var genreList = _driver.FindElement(By.XPath(_elements.genre));
            var selectElement = new SelectElement(genreList);

            //Execute Test Case
            selectElement.SelectByValue("action");
            searchButton.Click();
            var page = _driver.FindElement(By.LinkText("Next »"));
            page.Click();
            Thread.Sleep(2000);
            page = _driver.FindElement(By.LinkText("Last »"));
            page.Click();
            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;

            //Validate Result and Close The Browser
            Assert.AreNotEqual("0", searchResult);
            _driver.Close();
        }

        [TestMethod]
        public void Search_Using_ChooseAndGoBack()
        {
            //Declare Needed Elements
            var searchButton = _driver.FindElement(By.XPath(_elements.searchButton));
            var yearList = _driver.FindElement(By.XPath(_elements.year));
            var selectElement = new SelectElement(yearList);
            string searchYear = "2020";

            //Execute Test Case
            selectElement.SelectByValue(searchYear);
            searchButton.Click();

            //Get Result
            Thread.Sleep(2000);
            var searchResult = _driver.FindElement(By.XPath(_elements.searchResult)).Text;
            var year = _driver.FindElement(By.ClassName("browse-movie-year")).Text;

            //Validate Result First Time
            Assert.AreNotEqual("0", searchResult);
            Assert.AreEqual(searchYear, year);

            //Choose a Movie and Go Back
            var firstMovie = _driver.FindElement(By.XPath(_elements.firstMovie));
            firstMovie.Click();
            Thread.Sleep(1000);
            _driver.Navigate().Back();
            Thread.Sleep(2000);

            //Validate Result Second Time
            Assert.AreNotEqual("0", searchResult);
            Assert.AreEqual(searchYear, year);
            _driver.Close();
        }
    }
}
