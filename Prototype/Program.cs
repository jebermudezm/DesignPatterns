
//In this example, the IPrototype interface defines the Clone method,
//which creates a new object with the same properties as the original object.
//The ConcretePrototype1 and ConcretePrototype2 classes are concrete implementations
//of the IPrototype interface, which have different properties that can be cloned.

//The Client class uses the IPrototype interface to create a new object by cloning
//an existing object. The OutputDetails method is used to output the properties of
//the original object and the new object.

//To use the Prototype pattern, a client would create an instance of the Client class
//with an instance of a concrete prototype class as a parameter, and then call the Run method
//to clone the prototype and output the details of the original object and the new object.

using Prototype;

IPrototype prototype = new ConcretePrototype1(1);
Client client = new Client(prototype);
client.Run();

prototype = new ConcretePrototype2("Prototype 2");
client = new Client(prototype);

client.Run();