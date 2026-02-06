# Assignment 02 - Selenium WebDriver Testing

This project contains automated UI tests for [UITestingPlayground](https://uitestingplayground.com) using Selenium WebDriver with C# and NUnit.

## Project Structure

The solution follows the **Page Object Model (POM)** design pattern:

        Base: Contains `BaseTest.cs` which handles setup and teardown (initializing `ChromeDriver`, `WebDriverWait`, etc.).
        Pages: Contains page classes (e.g., `SampleAppPage.cs`, `AlertsPage.cs`) that model the web pages and their interactions.
        Tests: Contains the test classes (e.g., `SampleAppTests.cs`) that execute the test scenarios using the Page Objects.

## Prerequisites

        [.NET 10.0 SDK](https://dotnet.microsoft.com/download)
        Google Chrome browser

## How to Run Tests

Navigate to the project directory and run the following command:

        dotnet test


## Technologies Used

        Language: C# (.NET 10.0)
        Testing Framework: NUnit
        Browser Automation: Selenium WebDriver (Chrome)
