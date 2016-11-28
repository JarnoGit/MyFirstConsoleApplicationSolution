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

Scenario: I want more dogs and cats
Given I have 0 pets
When I buy 1 cat and 2 dog 
Then the number of pets I have is 3