Feature: Working with variables

Scenario: I want a cat var step
Given I have 0 pets
When I buy 'Fluffy', a 'Siamese' cat with an age of 4 and happiness 0.3
When I buy 'Iek', a 'klotekat' cat with an age of 4 and happiness 0.3
Then the number of pets I have is 1
