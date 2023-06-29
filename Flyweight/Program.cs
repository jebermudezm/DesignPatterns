//In this example, ICar is the flyweight interface that defines the common behavior for all cars.
//Car is a concrete flyweight that implements ICar. CarFactory is the flyweight factory
//that manages the creation and sharing of flyweights. Client is the class that uses the flyweights.

//When the client requests a car from the factory, the factory checks if a flyweight with
//the requested brand and model already exists. If it does, the factory returns the existing
//flyweight. If it doesn't, the factory creates a new flyweight and adds it to its dictionary
//of flyweights, then returns the new flyweight.

//When the client uses a flyweight to perform an operation, the operation is performed on the
//shared state of the flyweight, which is the brand and model of the car.
//This allows the client to reuse flyweights and minimize memory usage.



// Usage
using Flyweight;

Client client = new Client();
client.Run();
