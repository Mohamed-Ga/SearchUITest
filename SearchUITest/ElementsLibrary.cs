using System;
using System.Collections.Generic;
using System.Text;

namespace SearchUITest
{
    class ElementsLibrary
    {
        public string searchButton = "//*[@id='main-search-btn']/input";
        public string searchBox = "//*[@id='main-search-fields']/input";
        public string searchResult = "/html/body/div[4]/div[4]/div/h2/b";
        public string quality = "//*[@id='main-search-fields']/div[1]/select";
        public string genre = "//*[@id='main-search-fields']/div[2]/select";
        public string rating = "//*[@id='main-search-fields']/div[3]/select";
        public string year = "//*[@id='main-search-fields']/div[4]/select";
        public string language = "//*[@id='main-search-fields']/div[5]/select";
        public string order = "//*[@id='main-search-fields']/div[6]/select";
        public string quickSearch = "//*[@id='quick-search-input']";
        public string firstChoice = "/html/body/div[4]/div[2]/ul/li[1]/a";
        public string downloadButton = "//*[@id='movie-poster']/a/span";
        public string firstMovie = "/html/body/div[4]/div[4]/div/section/div/div[1]/div/a";
    }
}
