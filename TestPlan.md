# SearchUITest

## Website used to perform the test cases: "https://yts.mx/"

## Search filters/features provided by the website:
- Quick Search with Suggestion after entering at least 3 characters
- Advanced search using keywords
- Advanced search using qualiyt
- Advanced search using genre
- Advanced search using rating
- Advanced search using release year
- Advanced search using language
- Order search results using different options

## Search Scenarios:  
1- Search results displayed should be relevant to search criteria  
2- % sign in search keyword should not redirect to 404 ERROR  
3- When user start typing word in quick search it should suggest words that matches typed keyword  
4- There should be pre-defined search criteria for suggestions e.g. after typing first 3 letter it should suggest matching keyword  
5- When user clicks on any link from result and navigates back, then result should be maintained  
6- After clicking Search field - search history should be displayed (latest search keyword)  
7- Pagination should be tested for searches returning high number of records  
8- Total number of search records/results should be displayed on page  
9- User should be able to search when he enters the keyword and hits ‘Enter’ button on keyboard  

## Test Cases:  
1- Search_NoData  
Description: validates that searching without entering any data will gets all the results on the website  


2- Search_Using_ValidName  
Description: searching with a keyword and validates that the result is related to the search criteria  


3- Search_Using_PercentageSign  
Description: validates that using '%' as a keyword doesn't direct you to 404 ERROR  


4- Search_Using_ValidName_PressingEnter  
Description: validates that pressing enter on the keyboard after entering a keyword takes you to the search result  


5- Search_Using_InvalidName  
Description: validates that entering a keyword that doesn't exist in the website results in "0 result found"  


6- Search_Using_ValidQuality  
Description: searching using a random quality and validate that the result is related to the search criteria  


7- Search_Using_ValidRating  
Description: searching using a random rating and validate that the result is related to the search criteria  


8- Search_Using_ValidGenre  
Description: searching using a random genre and validate that the result is related to the search criteria  


9- Search_Using_ValidYear  
Description: searching using a random release year and validate that the result is related to the search criteria  


10- Search_Using_ValidLanguage  
Description: searching using a random language and validate that the result is related to the search criteria  


11- Search_Using_ValidOrder  
Description: searching using a random ordering and validate that the result is related to the search criteria  


12- Search_Using_QuickSearch  
Description: search using the quick search and validates that the suggestion shows after entering at least 3 characters  


13- Search_Using_DifferentCriteria  
Description: search using a mix of different search criteria and validates that the result is related to the search criteria  


14- Search_Using_ValidGenre_GoThroughMultiplePages  
Description: validates that pagination works for high numbers of search results  


15- Search_Using_ChooseAndGoBack  
Description: validates than choosing a certain search result and going back takes you to the same search  



       
