# SeleniumWithC
Selenium with example using C# in a page object pattern

SETUP:
 - VS Code 1.85.2
 - VS Code Extensions: .NET Core Test Explorer, .Net Install Tool, c#, c# Dev Kit, IntelliCode for c# Dev Kit, NuGet Package Manager
 - .Net 7.0 for most the project
 - .Net 5.0 for trxlog2html

How to run from command line:
 - https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test
 - Command: dotnet test SeleniumWithC.csproj --logger "trx;LogFileName=SeleniumWithC.trx"

Reporting:
 - trxlog2html can be used to convert the trx into an html
 - Requires .Net 5.0 installation
 - Install with:  dotnet tool install --global trxlog2html --version 1.0.0
 - Command: trxlog2html -i SeleniumWithC.trx -o SeleniumWithC.html

Unit Testing Frameworks: https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/
 - Currently going with MSTest, but each has its strengths and weaknesses

Page Object Model:
 - This project utilizes the Page Factory in selenium to implement the Page Object Model
 - For more information see: https://www.guru99.com/page-object-model-pom-page-factory-in-selenium-ultimate-guide.html

Logging:
- Microsoft.Extensions.Logging has been added. This implementation has limitations. The biggest being that the log itsn't output to a file. 


Enhancements left to add:
 - logging output to a file (use nlog, log4net, or serilog)
 - Cucumber or BDD layer

