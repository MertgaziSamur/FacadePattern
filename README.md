### FacadePattern ###

In this repository I will tell you about one of the structural patterns, ***Facade***.
This design pattern **hides clutter in one or more classrooms behind a facade**. <br/>
A structure with complex subsystems; We can simplify it by creating a Facade 
class that provides a single, reasonable interface. <br/>
***Facade*** provides a simple interface and incorporates subsystems into this interface.In this interface we will write, subclasses should be able to work 
independently of our Facade class, Facade will only be an interface that provides ease of use in our design.
<br/> <br/>

# How do things get easier with Facade? #
- Without making our complex system dependent; we can make it easier to use by creating a Facade class that provides a single, more reasonable interface. <br/>
- The Facade class will not encapsulate subclasses. It will provide a simple interface to their functions. <br/>
- Classes in the subsystem will still be available to the client.
- We can combine different features by writing different Facade classes for different clients. My subsite remains the same, it remains independent from the client, its features and usage vary according to the clients. <br/>
- Separates the facade client from the subsystem.

***In summary*** Facade acts as an intermediate class to reduce the code clutter of the client class in a project. Client code uses facade only, but subclasses Facade class
can also use. ***Codes in Facade also work on the client.***
