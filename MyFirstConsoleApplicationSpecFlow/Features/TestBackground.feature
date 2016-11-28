Feature: Working with Backgrounds

Background: The number of Pets I have now
Given I have 0 pets

Scenario: I want a cat
When I buy a cat  
Then the number of pets I have is 1

Scenario: I want a cat and a dog
When I buy a cat 
And I buy a dog
Then the number of pets I have is 2

Scenario: I want more dogs and cats
When I buy 1 cat and 2 dog 
Then the number of pets I have is 3