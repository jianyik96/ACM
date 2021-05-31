Abstract Class
1. An incomplete class with one or more members that are not implemented
2. An abstarct class cannot be instantiated
3. Intented for se as a base class
4. public abstarct class EntityBase{}

Sealed Class
1. A concrete class that cannot be extended through inheritance.
2. Use it to prevent overridding the class functionality
3. public sealed class Customer{}

Preparing Overridable Base Class Members
Abstract
1. Method signature as place holder with no implementation
2. Only use in abstarct class
3. Must be overridden by derived class
4. public abstract bool Validate();

Virtual
1. Method with default implementation
2. Use in abstract or concrete classes
3. Optinally overriden by derrived class
4. public virtual bool Validate{}


Object-Oriented Programming (OOP)
1. Identifying classes
	- Represents bussines entities
	- Define properties (data)
	- Defines method (action/ behavior)

2. Separating responsibilities
	- Minimizes coupling
	- Maximizes cohesion
	- Simplifies maintenance
	- Improves testability

3. Establishing relationships
	- Defines how objects work together to perform the operations of the application

4. Leveraging reuse
	- Involves extracting commonality
	- Building reusbale classes/ components
	- Defines Interfaces

Method Terminology

public Customer Retrieve(int customerId) 
	Signature

public Customer Retrieve(int customerId)
public List<Customer> Retrieve
	Overloading

public Cutomer() {}
public Cutomer(int customerId) {}
	Constructor