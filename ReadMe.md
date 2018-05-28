# Trip Planner Automation Test 1

Automation Exercise (notes from Exercise)

Create an automated test for the scenario below using open-source tooling (e.g. Selenium) in the language (C#, Java etc) and framework (xUnit, BDD etc) of your choice. Note that although the scenario is defined in Gherkin, a BDD implementation is not mandatory. 
 
Scenario: 
- A trip request can be executed and results returned   
- Given Phileas is planning a trip   
- When he executes a trip plan from "North Sydney Station" to "Town Hall Station"   
- Then a list of trips should be provided  
 
Use the exercise to showcase best-practice software development and test automation techniques.  

The URL for Trip planner is ​https://transportnsw.info/trip

## Getting Started

This C# solution requires Visual Studio 2017 - Community edition should suffice.
Download the whole solution to your PC.

### Prerequisites

For Visual Studio 2017 the following additonal Nuget packages are required:
- DotNetSeleniumExtras.WaitHelpers -  v3.11.0
- NUnit - v3.10.1
- Selenium.Support - v3.12.0
- Selenium.WebDriver - v3.12.0
- Selenium.WebDriver.ChromeDriver - v2.38.0.1

For the application to run:
- Google Chrome - v66.0.3359.181 (64-bit)
- Microsoft .NET Framework 4.6.1: https://www.microsoft.com/en-au/download/details.aspx?id=49981

### Installing

Install the prerequisites.
Copy the contents of the .\TripPlannerTest1\bin\Release directory (excluding app.publish) into your working directory or new folder on your PC. 
Double-click on the TripPlannerTest1.exe (application).  The test will execute - it will input the data as per the scenario and return a results set.  It will throw a SuccessException if it completes successfully otherwise other exceptions will be thrown.
Allow the test to complete.

## Authors

* **Nicole Baker** - *Initial work* - [nbaker74](https://github.com/nbaker74)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

