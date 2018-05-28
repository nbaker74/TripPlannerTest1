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

Download the whole solution to your PC.

### Prerequisites

Microsoft .NET Framework 4.6.1:
https://www.microsoft.com/en-au/download/details.aspx?id=49981

### Installing

Install the prerequisites.
Copy the contents of the .\TripPlannerTest1\bin\Release directory (excluding app.publish) into your working directory or new folder on your PC. 
Double-click on the TripPlannerTest1.exe (application).  The test will execute - it will input the data as per the scenario and return a results set.  It will throw a SuccessException if it completes successfully otherwise other exceptions will be thrown.
Allow the test to complete.

## Authors

* **Nicole Baker** - *Initial work* - [nbaker74](https://github.com/nbaker74)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

