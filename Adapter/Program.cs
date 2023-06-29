//In this example, the ITarget interface defines the Request method,
//which is the expected interface of the client.

//The Adaptee class is the existing class that the client cannot use directly.
//It has a SpecificRequest method that the client cannot call directly.

//The Adapter class adapts the Adaptee class to the ITarget interface by implementing
//the Request method and delegating to the SpecificRequest method of the Adaptee class.

//The Client class uses the Adapter class to call the Request method, which in turn calls
//the SpecificRequest method of the Adaptee class.

//To use the Adapter pattern, a client would create an instance of the Adaptee class,
//create an instance of the Adapter class with the Adaptee instance as a parameter,
//and then call the Request method on the ITarget instance. The client can use the
//ITarget interface to call the Request method, without needing to know about the Adaptee class.

using Adapter;

Client client = new Client();
client.Run();