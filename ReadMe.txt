Types of Relationship
1. Collaboration ("uses a")
2. Composition ("has a")
	- Aggregation
	- Composition
3. Inheritance ("is a")

Evaluate Coupling
What: Dependence on other classes or external resources
How: Extract dependecies into their own classes
Why: Easier to test and maintain

Example: Move the responsibility for accessing the data store to a repository class

Evaluate Cohension
What: Class members should relate to class purpose
How: Extaract unrelated members into their own classes
Why: Easier to understand, test and maintain

Example: Move the responsibility for managing addresses into a separate class 

Unit Testing Method

Define tests for valid and invalid scenarios

Organize the test
- Arrange: Set up the best
- Act: Call the method being tested
- Assert: Determine the result
