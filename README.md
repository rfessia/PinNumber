# PinNumber
*Return a list of 1000 unique pin numbers which meets the criteria set out below:*
- *Pin numbers must:*
1. *Be 4 Digits*
2. *Cannot have incremental digits, e.g. 1234, or 1248*
3. *Cannot have repeated digits, e.g. 8888, or 8863*
- *In the list of 1000, we cannot have repeated pin numbers (this is the unique criteria)*

## Architecture
Pin number has 3 projects:
1. **PinNumber.UI:** User interface layer. It is a Console App, and the goal is to show the user the result.
2. **PinNumber.Generator:** Logic layer. It is a Class Library that has validators and generators to solve the logic of the PinNumber problem.
3. **PinNumber.Test:** It is a Unit Test Proyect to verify the quality of the project.

## Considerations
1. Allowed only for 4-digit positive numbers: from 1000 to 9999
2. The repetition of digits may or may not be consecutive

## Test
Various tests were performed trying to cover most possible cases. For the test coverage, "Coverage test" was used, obtaining the following result:

![alt text](https://github.com/rfessia/PinNumber/blob/master/common/images/CodeCoverage.png "Code Coverage")

As a conclusion of the test coverage, I can declare an effective coverage of 90% of the code due to infrastructure code or user interface. Less than 90% of the coverage, new tests should be created.
