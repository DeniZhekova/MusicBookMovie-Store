# MusicBookMovie Assignmennt by Denitsa Zhekova 

----
## Introduction


Mbm Store (Music Book Movie Store) is the name of the project and this abbreviation
might be written within the document. 

The key learning objectives of this assignment are:

- Object Oriented Programming (OOP)
- Model View Controller (MVC) application architecture
- Learn to use and build websites with ASP.NET MVC
This document provides a detailed explanation of MBM Store to help you achieve a
thorough understanding of its capabilities, this includes the installation and use of the
system.
It is also useful background reading for anyone involved in developing, monitoring or
further interaction with MBM Store Project..

----
## ASP.NET MVC Architecture

The MVC architectural pattern has existed for a long time
in software engineering. Almost all the languages use
MVC with slight variation, but conceptually it remains the
same.
Model-view-controller (or MVC for short) is an architectural
template most commonly used when creating a user
interface. It "splits" the application into three interconnected
parts. This is done in order to separate the internal
presentation of information from the ways in which the information is presented to and
received by the user. The MVC template separates these major components, which allows
developers to use rewritten code more efficiently and also allows concurrent development.

----

##UML Diagram


*UML digram is included in the pdf - Report for this project*

>A class diagram in the Unified Modeling Language (UML) is a type of static structure diagram
that describes the structure of a system by showing the system's: classes, their attributes, operations
(or methods),and the relationships among objects. The name of the class appears in the first partition.
Attributes are shown in the second partition. The attribute type is shown after the colon. Operations
are shown in the third partition. They are services the class provides. The return type of a method is
shown after the colon at the end of the method signature. The +, - and # symbols before an attribute
and operation name in a class denote the visibility of the attribute and operation.
>+ denotes public attributes or operations ; - denotes private attributes or operations ;
># denotes protected attributes or operations
In Figure 2 we can see that the classes Movie, Book and Music CD are subclasses of the supeerclass
Product and they inherit all the attributes of this class. While Movie and Book are standalone classes
MusicCD is composed of multiple Tracks. The class Customer can have 0 or more Invoices, these beeing
built on the Order (0...n(orders) - 1(product)). The Cart is mearly a feature implement to aid the user with
an overview of the order before is created.



----
## Tag Helpers
>Tag helpers are an opt-in feature. They are not available to the page by default. They are enabled by
adding an @addTagHelper directive to the page
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
The @addTagHelper directive is followed by a wildcard character (*) to specify that all tag helpers found
in the specified assembly should be used, and then the name of the assembly containing the tag
helpers is provided.

>In this way I can provide C# code to the view and this comes with multiple advantages. For one, estethics
of the code, insetring a block of C# code in the HTML document is going to make it look horrendes. Factor
number two, is that in the case of following the development of the application with thests, we could easily
implement a test based on the tag and see if there are issues with the tag instead pf manually checking
the functionality of the HTML code. In other words it helps us achieve :
An HTML-friendly development experience.
A rich IntelliSense environment for creating HTML and Razor markup.
A way to make you more productive and able to produce more robust, reliable, and maintainable
code using information only available on the server.
>As we divide the logic of our application into three tasks (input logic, business logic, interface logic), testing
of these components would become very easy. We can design the components of our application in such
a way that these are easily replaceable or can be modified easily. We can plug our own view engine, URL
routing strategy, action method constraint serialization. Instead of depending on class to create objects we
use a technique dependency injection (DI) which enable us to inject object into classes.
MVC provide URL mapping component that helps us to build using understandable and searchable URLs.
Instead of using file name extensions MVC support URL naming patterns that are very useful for search
engine optimization (SEO) and representational state transfer (REST) addressing.

>In Figure 9, we can see the development of a tag helper that is used to create pagination in my application. I create a “PageUrlValues”
which is assignd to the for loop iterator value 'i' in this way, by dividing the total amount of pages to the elements we want to display per page currently set at 4, I am creating an innerHTML C sharp code thet can be appended to the result, which will insert it in a <div>. The output will be the appended code in the HTML document, changing the URL, based on the current page the user is in.
----
## Conclusion
* As we divide the logic of our application into three tasks (input logic, business logic, interface logic), testing
of these components would become very easy. We can design the components of our application in such
a way that these are easily replaceable or can be modified easily. We can plug our own view engine, URL
routing strategy, action method constraint serialization. Instead of depending on class to create objects we
use a technique dependency injection (DI) which enable us to inject object into classes.
* MVC provide URL mapping component that helps us to build using understandable and searchable URLs.
Instead of using file name extensions MVC support URL naming patterns that are very useful for search
engine optimization (SEO) and representational state transfer (REST) addressing.

----
## Thank you
*Please not that this is a partial text for my assignment, the short documentation above is not complete!*
