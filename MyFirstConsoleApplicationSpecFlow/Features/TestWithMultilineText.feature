Feature: Working with Multiline Text

Scenario: I want a cat multiline
Given I have 0 pets
When I buy the following pet
| name   | age | happiness | breed   |
| Fluffy | 4   | 0.3       | Siamese |
Then I should have the following pet
"""
Name: Fluffy
Age: 4
Happiness: 0.3
Breed: Siamese
"""