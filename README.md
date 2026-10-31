# OrangeHRM Automation Testing Project Using Selenium C#

## 1. Project Introduction

This project is an automation testing project developed using C#, Selenium WebDriver, and MSTest in Visual Studio.

The purpose of this project is to automate some basic functionalities of the OrangeHRM web application. Instead of performing every testing step manually, Selenium is used to open the browser, interact with web elements, enter data, click buttons, and verify the results.

This project is designed for beginners who want to understand the basics of web automation testing using C#.

The project follows the **Page Object Model (POM)** design pattern. This approach organizes page-related code separately from test cases, making the project easier to understand and maintain.

---

## 2. Project Objectives

The main objectives of this project are:

- To learn automation testing using Selenium WebDriver and C#.
- To automate the login functionality of OrangeHRM.
- To navigate to the Admin section.
- To search for a username in User Management.
- To understand how web elements are located using Selenium.
- To organize code using the Page Object Model.
- To understand how test cases are created and executed using MSTest.
- To learn how test data and element locators can be stored separately.
- To execute automated tests using Visual Studio Test Explorer.

---

## 3. Technologies Used

### C#

C# is the programming language used to write the automation scripts. It contains the instructions that control the browser and perform the testing steps.

### Selenium WebDriver

Selenium WebDriver is a browser automation tool. It allows the automation scripts to open a browser, find web elements, enter text, click buttons, and interact with a web application.

### Visual Studio

Visual Studio is the development environment used to create, edit, build, and run the C# automation project.

### MSTest

MSTest is a testing framework used to create and execute automated test cases.

It provides attributes and assertion methods to organize tests and verify whether the actual results match the expected results.

### JSON

JSON is a format used to store structured data. In this project, the `Data.json` file is used to store test data.

### Page Object Model (POM)

Page Object Model is a design pattern in which the elements and actions of individual web pages are organized into separate classes.

For example, login-related actions are placed in `LoginPage.cs`, while User Management actions are placed in `UserManagementPage.cs`.

---

## 4. Project Structure

The project contains separate folders and files to organize the automation code.

```text
software_assignment/
│
├── DataFile/
│   └── Data.json
│
├── LocatorFile/
│   └── Locator.cs
│
├── MiscFile/
│   ├── BaseClass.cs
│   └── JsonReader.cs
│
├── PageClasses/
│   ├── LoginPage.cs
│   ├── DashboardPage.cs
│   ├── AdminPage.cs
│   └── UserManagementPage.cs
│
├── UnitTest1.cs
├── software_assignmnet.csproj
└── software_assignmnet.slnx
```

**Note:** The file names above follow the project structure used in this assignment.

---

## 5. Explanation of Project Folders and Files

### 5.1 DataFile Folder

The `DataFile` folder contains the `Data.json` file.

#### Data.json

This file stores test data in JSON format.

Test data means the information used while executing test cases, such as usernames, passwords, or other input values.

Keeping test data in a separate file can help separate the data from the automation code.

**Example:** A test case can read a username from a JSON file and enter it into a search field.

The actual contents of `Data.json` depend on the data configured in the project.

**Important:** Do not upload real passwords or other confidential information to a public GitHub repository.

### 5.2 LocatorFile Folder

The `LocatorFile` folder contains `Locator.cs`.

#### Locator.cs

A locator tells Selenium how to find a particular web element on a webpage.

Web elements include:
- Username input fields
- Password input fields
- Login buttons
- Search buttons
- Navigation menus
- Tables and result rows

Selenium supports different locator strategies, including:
- ID
- Name
- XPath
- CSS Selector
- Class Name

In this project, `Locator.cs` stores locators that are used by the page classes.

Keeping locators in a separate file makes them easier to find and update.

**Example:** A username search field can be located using XPath. The page class can then use that locator to enter a username.

### 5.3 MiscFile Folder

The `MiscFile` folder contains common helper classes used by the project.

#### BaseClass.cs

The `BaseClass.cs` file contains common setup or helper functionality used by the automation tests.

Depending on the implementation, this class may handle:
- Initializing the browser.
- Creating the Selenium WebDriver instance.
- Opening the OrangeHRM website.
- Providing access to the browser driver.
- Adding waits between testing steps.
- Performing common test setup and cleanup tasks.

The purpose of a base class is to avoid repeating the same common setup code in every test class.

#### JsonReader.cs

The `JsonReader.cs` file is responsible for reading test data from a JSON file.

It helps the automation code access the information stored in `Data.json`.

For example, a test may need a username or password from the JSON file. The JSON reader can load the data so the test can use it.

The exact data fields and reading methods depend on the code implemented in this class.

### 5.4 PageClasses Folder

The `PageClasses` folder contains classes representing different pages or sections of OrangeHRM.

These classes follow the Page Object Model design pattern.

#### LoginPage.cs

The `LoginPage.cs` file contains functionality related to the OrangeHRM login page.

Its responsibilities may include:
- Finding the username field.
- Finding the password field.
- Entering login credentials.
- Clicking the Login button.
- Supporting login-related interactions.

Instead of writing all login interactions directly in a test case, the test can call the methods provided by `LoginPage.cs`.

#### DashboardPage.cs

The `DashboardPage.cs` file contains functionality related to the OrangeHRM dashboard.

The dashboard is the page displayed after a successful login.

This class can help the test interact with or verify dashboard elements, depending on the methods implemented in the project.

#### AdminPage.cs

The `AdminPage.cs` file contains functionality related to the Admin section of OrangeHRM.

Its responsibilities may include:
- Navigating to the Admin section.
- Interacting with Admin page elements.
- Supporting verification that the Admin page is displayed.

This class helps keep Admin-related actions separate from login and other page actions.

#### UserManagementPage.cs

The `UserManagementPage.cs` file contains functionality related to searching and interacting with users in the User Management section.

The implemented functionality includes methods for:
- Entering a username in the search field.
- Selecting the Admin role.
- Clicking the Search button.
- Clicking the Reset button.
- Checking whether a username appears in the results.
- Checking whether the username field is empty.

These methods allow test cases to perform User Management actions without placing every Selenium command directly inside the test class.

### 5.5 UnitTest1.cs

The `UnitTest1.cs` file contains the automated test cases.

This is where the testing process is organized and executed using MSTest.

The test methods call the page classes to perform actions and use assertions to verify the results.

The current project includes tests for:
1. Login functionality.
2. Admin page navigation or verification.
3. User Management username search.

MSTest attributes, such as `[TestClass]` and `[TestMethod]`, identify test classes and test methods.

Assertions are used to check whether the expected result occurred.

For example, an assertion can verify that a page element is displayed or that a username appears in the search results.

### 5.6 Project File: software_assignmnet.csproj

The `.csproj` file is the C# project configuration file.

It contains project settings and information about the dependencies required by the project.

Visual Studio uses this file to understand how to build the project.

### 5.7 Solution File: software_assignmnet.slnx

The `.slnx` file is the Visual Studio solution file.

It helps Visual Studio organize and open the project as a solution.

The solution provides a convenient way to access the project and its files through the Visual Studio interface.

---

## 6. Automated Test Cases

### Test Case 1: Login Test

**Objective:** To verify that a user can log in to OrangeHRM using valid credentials.

**Steps:**
1. Open the OrangeHRM login page.
2. Locate the username input field.
3. Enter the username.
4. Locate the password input field.
5. Enter the password.
6. Click the Login button.
7. Verify that login was successful.

**Expected Result:** The application should accept valid credentials and display the dashboard.

**Purpose:** This test demonstrates basic browser automation, element location, text entry, button clicking, and result verification.

### Test Case 2: Admin Page Test

**Objective:** To verify navigation to the Admin section.

**Steps:**
1. Open OrangeHRM.
2. Log in using valid credentials.
3. Navigate to the Admin section.
4. Verify that the Admin page is displayed.

**Expected Result:** The Admin page should open successfully.

**Purpose:** This test demonstrates how Selenium can interact with navigation elements and how a test can verify that the expected page is displayed.

### Test Case 3: User Management Username Search

**Objective:** To verify that the User Management section can search for a username.

**Steps:**
1. Log in to OrangeHRM.
2. Open the Admin section.
3. Access User Management.
4. Enter a username into the username search field.
5. Click the Search button.
6. Check the search results for the specified username.

**Expected Result:** If a matching user exists and the search is configured correctly, the results should display that user.

**Purpose:** This test demonstrates how to enter search criteria, execute a search, and verify the resulting information.

**Note:** The actual result depends on the username entered and the users available in the OrangeHRM test environment.

---

## 7. How the Page Object Model Works

The Page Object Model separates page interactions from test execution.

For example, consider the User Management username search test.

1. The test method starts in `UnitTest1.cs`.
2. The test uses the relevant page class to interact with User Management.
3. The page class uses locators from `Locator.cs` to find the required elements.
4. Selenium WebDriver performs actions such as entering a username and clicking Search.
5. The test checks the result using an assertion.

This separation makes the code easier for beginners to read because each class has a specific responsibility.

If a locator changes, it can be updated in the locator file instead of searching through every test case.

---

## 8. How to Run the Project

Follow these steps to run the automation tests in Visual Studio.

### Step 1: Open the Project

Open Visual Studio and load the `software_assignmnet.slnx` solution file.

### Step 2: Restore Dependencies

Make sure the required NuGet packages are installed and restored.

The project needs compatible Selenium WebDriver and MSTest dependencies.

### Step 3: Check the Test Data

Open `Data.json` and confirm that the test data required by the automation code is configured correctly.

Do not share confidential credentials in a public repository.

### Step 4: Check the Browser

Make sure Google Chrome is installed and the Selenium setup is compatible with the browser environment.

### Step 5: Open Test Explorer

In Visual Studio, open **Test → Test Explorer**.

Test Explorer displays the test cases discovered by MSTest.

### Step 6: Run a Test

Select an individual test and click **Run**.

Running one test at a time makes it easier for beginners to observe the browser actions and understand what each test does.

### Step 7: Check the Results

After the test finishes, check the result in Test Explorer.

A passed test indicates that the test completed without a failed assertion or other reported test failure.

If a test fails, review the error message and check the locators, test data, browser setup, and expected result.

---

## 9. Benefits of This Project

This project provides practical experience with:

- Writing automation scripts in C#.
- Controlling a web browser using Selenium WebDriver.
- Finding web elements using locators.
- Entering text and clicking buttons.
- Automating login and search functionality.
- Organizing page interactions using the Page Object Model.
- Separating test data from automation code.
- Creating test cases with MSTest.
- Verifying results using assertions.
- Running automated tests in Visual Studio Test Explorer.
- Managing and sharing source code using Git and GitHub.

---

## 10. Conclusion

The OrangeHRM Automation Testing Project demonstrates the basic concepts of web automation testing using Selenium WebDriver, C#, Visual Studio, and MSTest.

The project automates login, Admin page navigation, and User Management username search.

By organizing the code into page classes, locator files, helper classes, and test cases, the project demonstrates how the Page Object Model can be used to structure an automation testing application.

This project provides a beginner-friendly introduction to writing, organizing, executing, and verifying automated web tests.

---

## Author

**Eshaal**
