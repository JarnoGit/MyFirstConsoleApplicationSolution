Feature: SpecFlow Scenario Outlines

Scenario Outline: I do not now how many cats and dogs I want
Given I have 0 pets
When I buy <catsIWant> cat and <dogsIWant> dog 
Then the number of pets I have is <petsIHave>
Examples: 
| catsIWant | dogsIWant | petsIHave |
| 1         | 1         | 2         |
| 2         | 0         | 2         |
| 1         | 3         | 4         |




