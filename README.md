# OOP C# Tutorial and examples

Object-oriented programming (OOP) is a programming paradigm based on the concept of "objects", which can contain data, in the form of fields (often known as attributes or properties), and code, in the form of procedures (often known as methods). A feature of objects is an object's procedures that can access and often modify the data fields of the object with which they are associated (objects have a notion of "this" or "self"). In OOP, computer programs are designed by making them out of objects that interact with one another. OOP languages are diverse, but the most popular ones are class-based, meaning that objects are instances of classes, which also determine their types.

# Definitions

## Class

A class is a blueprint for creating objects (a particular data structure), providing initial values for state (member variables or attributes), and implementations of behavior (member functions or methods).
The user-defined objects are created using the class keyword. The class is a blueprint that defines a nature of a future object. An instance is a specific object created from a particular class. Classes are used to create and manage new objects and support inheritance—a key ingredient in object-oriented programming and a mechanism of reusing code.

## Abstract class

An Abstract class is never intended to be instantiated directly. This class must contain at least one abstract method, which is marked by the keyword or modifier abstract in the class definition. The Abstract classes are typically used to define a base class in the class hierarchy. Generally, we use abstract class at the time of inheritance.
A user must use the override keyword before the method which is declared as abstract in child class, the abstract class is used to inherit in the child class.

- An abstract class cannot be inherited by structures.
- It can contains constructors or destructors.
- It can implement functions with non-Abstract methods.
- It cannot support multiple inheritance.
- It can’t be static.

## Interfaces

An interface contains definitions for a group of related functionalities that a class or a struct can implement.
By using interfaces, you can, for example, include behavior from multiple sources in a class. That capability is important in C# because the language doesn't support multiple inheritance of classes. In addition, you must use an interface if you want to simulate inheritance for structs, because they can't actually inherit from another struct or class.

## Inheritance

Is one of the fundamental attributes of object-oriented programming. It allows you to define a child class that reuses (inherits), extends, or modifies the behavior of a parent class. The class whose members are inherited is called the base class. The class that inherits the members of the base class is called the derived class.

## Polymorphism

Polymorphism means providing an ability to take more than one form and it’s a one of the main pillar concept of object oriented programming, after encapsulation and inheritance. Generally, the polymorphism is a combination of two words, one is poly and another one is morphs. Here poly means “multiple” and morphs means “forms” so polymorphism means many forms. Polymorphism provides an ability for the classes to implement a different methods that are called through the same name and it also provides an ability to invoke the methods of derived class through base class reference during runtime based on our requirements.

## Encapsulation

Is defined 'as the process of enclosing one or more items within a physical or logical package'. Encapsulation, in object oriented programming methodology, prevents access to implementation details. Abstraction and encapsulation are related features in object oriented programming. Abstraction allows making relevant information visible and encapsulation enables a programmer to implement the desired level of abstraction.

### Public Access Specifier

Allows a class to expose its member variables and member functions to other functions and objects. Any public member can be accessed from outside the class.

### Private Access Specifier

Allows a class to hide its member variables and member functions from other functions and objects. Only functions of the same class can access its private members. Even an instance of a class cannot access its private members.

### Protected Access Specifier

Allows a child class to access the member variables and member functions of its base class. This way it helps in implementing inheritance.

## Abstraction

Data Abstraction is the property by virtue of which only the essential details are exhibited to the user. The trivial or the non-essentials units aren’t exhibited to the user.
Data Abstraction may also be defined as the process of identifying only the required characteristics of an object ignoring the irrelevant details. The properties and behaviors of an object differentiate it from other objects of similar type and also help in classifying/grouping the objects.
