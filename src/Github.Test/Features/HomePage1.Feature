Feature: Home_Page1

    Github homepage is all there and working correctly

Background: I_am_on_the_homepage
    Given I navigated to https://github.com/

Scenario: Login_Fields_Are_Present_A
    And I have not logged in
    Then I can see the login and email fields

Scenario: Login_Fields_Are_Present_B
    And I have not logged in
    Then I can see the login and email fields    