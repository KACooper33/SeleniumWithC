# SeleniumWithC
Selenium with example using C# in a page object pattern

Unit Testing Frameworks: https://www.lambdatest.com/blog/nunit-vs-xunit-vs-mstest/
 - Currently going with MSTest, but each has its strengths and weaknesses

Page Object Model:
 - This project utilizes the Page Factory in selenium to implament the Page Object Model
 - For more information see: https://www.guru99.com/page-object-model-pom-page-factory-in-selenium-ultimate-guide.html

Logging:
- Microsoft.Extensions.Logging has been added. This implementation has limitations. The biggest being that the log itsn't output to a file. 

Enhancements left to add:
 - logging output to a file (use nlog, log4net, or serilog)
 - Cucumber layer