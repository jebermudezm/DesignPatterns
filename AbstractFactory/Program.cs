//In this example, the IAbstractFactory interface defines the methods for creating IProductA
//and IProductB objects.
//The ConcreteFactory1 and ConcreteFactory2 classes are concrete implementations of the
//IAbstractFactory interface, which create different sets of products.

//The IProductA and IProductB interfaces define the methods that must be implemented by the
//concrete product classes. The ConcreteProductA1, ConcreteProductA2, ConcreteProductB1, and
//ConcreteProductB2 classes are concrete implementations of the IProductA and IProductB interfaces.

//Finally, the Client class uses the IAbstractFactory interface to create the necessary IProductA
//and IProductB objects, and then uses them as needed.

using AbstractFactory;

IAbstractFactory abstractFactory = new ConcreteFactory1();
Client client = new Client(abstractFactory);
client.Run();

abstractFactory = new ConcreteFactory2();
client = new Client(abstractFactory);
client.Run();
