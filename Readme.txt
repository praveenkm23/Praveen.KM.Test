The solution is developed using .NET 4.7.1. The Web API methods are created to convert the number to words. 

jQuery is used to collect the data from input fields, invoke the Web API method and populate the result. 

Person name is directly populated in the output field from the input field and is not passed on to the Web API methods.

A custom js file (app.js) is added to the solution to validate the input fields and also to invoke the Web API methods.

MSTest is utilized to create the Unit test project. 

Since this is a simple application and the requirement was to run directly from Visual Studio, both the Web API and 
the MVC pages are in the same project. The solution can be further enhanced to separate out the Web API into a separate 
project and MVC web application in another project. 