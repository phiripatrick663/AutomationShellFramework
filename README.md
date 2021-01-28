# AutomationShellFramework
shell to build on C#, SpecFlow and NUnit framework
This shell framework was created to help get started on test automation using Visual Studio 2019. It contains thee projects; Configuration, Selenium, and SpecFlow. 

Configuration
This project houses all properties required by project to access test site, including URL, username, password among others in a json file. It also houses a method to 
read the json file and extract attributes as needed.

Selenium
This project contains all attributes to work with Selenium in running the project. Website elements are housed in a page object model and methods to interact with them 
in an extension file. A base page contains common elements to shared with step files. A browser factory file prepares 3 browsers to be interchanged by replacing browser choice in 
the json file. 

SpecFlow
This project houses feature and step files. Also included is a Scenario hooks file that is required to inject SpecFlow context in the project. This allows for creation
of browser instance and can be injected into other classes where it is needed. This file can be expanded to create screen capture routine in the After scenario or After step
method.
