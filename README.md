# ZOO
this is  a simple program divided into classes that is used to show a simple zoo UML diagram and show the inhertance and the diffrent kinds of classes and the polymorphism and also including the overriding for abstract and virtual classes so as you will see below the animal is the base class and also the abstract class for 3 classes that are also abstract classes (mammals,birds, reptiles) then this classes have classes under them as children for example mammals is the parent for the lion class (the lion class is a concret class) .
## UML Diagram for the zoo:

![uml](https://github.com/abdarahman-shaheen/Lab06-Zoo/blob/master/Zoo-UML-interface.jpg)

## The 4 concepts of OOP:
1. Encapsulation: Bundling data and related operations together within a class, providing a neat package that protects the data from outside interference and allows controlled access through defined interfaces.

2. Inheritance: Creating new classes by inheriting properties and behaviors from existing classes, enabling code reuse and the creation of specialized subclasses that add or modify functionality.

3. Polymorphism: Treating objects of different classes as if they were objects of a common superclass, allowing for interchangeable usage and the ability to override methods to provide different implementations.

4. Abstraction: Simplifying complex systems by focusing on essential features and hiding unnecessary details, providing a high-level view that aids understanding and managing complexity.


## This are some examples of usage of Polymorphism in the code:
1. Polymorphism with the `Mammals` class:
   - `Mammals` is a superclass that defines common properties and behaviors of mammals.
   - `Lion` and `Rabbit` are subclasses of `Mammals` and inherit its properties and behaviors.
   - The objects `m1` and `m2` are created as instances of `Lion` and `Rabbit` respectively but are declared as `Mammals`.
   - Even though `m1` and `m2` are declared as `Mammals`, they can still access the overridden methods specific to their subclasses (`Sleep()` and `Eat()`).
   - This allows different types of mammals to be treated uniformly as `Mammals` while invoking their specific behaviors.

2. Polymorphism with the `Reptile` class.


   - `Reptile` is a superclass that defines common properties and behaviors of Reptiles.
   - `Snake` is a subclass of `Reptile` and inherits its properties and behaviors.
   - The object `r1` is created as an instance of `Snake` but is declared as `Reptile`.
  
## What is an interface in C#?

An interface in C# is a declaration of a set of methods that a class or struct must implement.
Interfaces are similar to abstract classes, but they have some important differences. First,
interfaces cannot have any fields. Second, all methods in an interface are abstract, meaning that they do not have any implementation code.

## Why use interfaces?

There are several reasons why you might want to use interfaces in your C# code. First, interfaces can be used to achieve multiple inheritance. In C#, a class can only inherit from one base class. However, it can implement multiple interfaces.
This allows you to create classes that have the functionality of multiple different types.

Interfaces are a powerful tool that can be used to improve the design and maintainability of your C# code. By understanding how to use interfaces, you can write code that is more modular, flexible, and reusable.

## Test
![Test](https://github.com/abdarahman-shaheen/Lab06-Zoo/blob/master/TestZooInterface.png)

