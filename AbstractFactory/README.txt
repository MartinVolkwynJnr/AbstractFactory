Abstract Factory: when and where you would use it

The Abstract Factory pattern provides a class that creates objects that are related by a common theme. The classic example is that of a GUI component factory which
creates UI controls for different windowing systems, such as, Windows, Motif, or MacOS. In case you’re familiar with Java Swing, it represents a great example of the 
use of the Abstract Factory pattern to build UI interfaces that are independent of their hosting platform. From a design pattern perspective, Java Swing succeeded, but
applications built on this platform are limited in their interactivity and responsiveness compared to native Windows or native Motif applications.

Over time the meaning of the Abstract Factory pattern has evolved relative to the original GoF definition. Today, when developers talk about the Abstract Factory
pattern they not only mean the creation of a ‘family of related or dependent objects' but also a simpler notion which is the creation of individual object instances.

Perhaps you are wondering why you would want to create objects using another class (called Abstract Factory) rather than calling constructors directly. Here are somereasons:
Constructors are limited in their control over the overall creation process. If your application needs more control then use a Factory instead. Possible scenarios where
this may be the case is when the creation of objects involves object caching, sharing or re-using of objects, and applications that need to maintain object and type counts.

Additionally, there are times when the client does not know exactly what type to construct. It is easier to code against a base type or an interface and then let a factory 
make this decision for the client (based on parameters or other context-based information). The provider-specific ADO.NET objects
(i.e. DbConnection, DbCommand, DbDataAdapter, etc.) are a good example of this.

Constructors don’t communicate their intention very well because they must be named after their class (or Sub New in VB). 
Having numerous overloaded constructors may make it hard for the client developer to decide which constructor to use. Replacing constructors with a Factory that
has intention-revealing creation methods may be preferred. Here is an example of 4 overloaded constructors. These first examples show that it is not always clear 
which one to use.

Participants

The classes and/or objects participating in this pattern are:
 AbstractFactory (ContinentFactory)
	o declares an interface for operations that create abstract products
 ConcreteFactory (AfricaFactory, AmericaFactory)
	o implements the operations to create concrete product objects
 AbstractProduct (Herbivore, Carnivore)
	o declares an interface for a type of product object
 Product (Wildebeest, Lion, Bison, Wolf)
	o defines a product object to be created by the corresponding concrete factory implements the AbstractProduct interface
 Client (AnimalWorld)
	o uses interfaces declared by AbstractFactory and AbstractProduct classes