Feature: Loginpage
    As a user
    I want to login to the application
    So I can access protected pages

@BDD_Test
Scenario: Verify login completes successfully with valid credentials
    Given I navigate to the login pages
    When I enter a username agileway and password testwise
    Then I should be redirected to the home page

# @newtest
# Scenario: Verify login fails if attempted with invalid credentials
#     Given I navigate to the login pages
#     When I enter an invalid username and password
#     And I click the login button
#     Then I should see an invalid credential warning
    