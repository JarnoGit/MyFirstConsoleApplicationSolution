Feature: Working with Tables

Scenario: I want a cat
Given I have 0 pets
When I buy the following cat
| name   | age | happiness | breed   |
| Fluffy | 4   | 0.3       | Siamese |
Then the number of pets I have is 1

Scenario: I want a dog
Given I have 0 pets
When I buy the following dog
| variable  | value  |
| name      | Boomer |
| age       | 1      |
| happiness | 9.0    |
| breed     | Boxer  |
Then the number of pets I have is 1