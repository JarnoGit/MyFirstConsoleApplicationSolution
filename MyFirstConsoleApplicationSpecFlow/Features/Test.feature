Feature: Demo Feature working with Specflow

Scenario: I want a cat
Given I have 0 pets
When I buy a cat  
Then the number of pets I have is 1

Scenario: I want a cat and a dog
Given I have 0 pets
When I buy a cat 
And I buy a dog
Then the number of pets I have is 2