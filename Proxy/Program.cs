//In this example, we have an ISubject interface that defines the common operations
//for both the RealSubject and the Proxy. The RealSubject class contains some core
//business logic, while the Proxy class serves as a surrogate or placeholder for the RealSubject.
//The Client class works with both the RealSubject and Proxy via the ISubject interface.

//When the Request method is called on the Proxy object, it checks access privileges before
//invoking the Request method on the RealSubject. The Proxy also logs the time of request.
//This is an example of the lazy loading technique where the RealSubject object is created
//only when it's needed, and not immediately upon creation of the Proxy.

//In the Main method, we create an instance of RealSubject and pass it to the Client
//object's ClientCode method. Then we create a Proxy object, passing in the RealSubject object,
//and pass it to the Client object's ClientCode method

using Proxy;

Client client = new Client();

RealSubject realSubject = new RealSubject();
Console.WriteLine("Client: Executing the client code with a real subject:");
client.ClientCode(realSubject);

Console.WriteLine();

Proxy.Proxy proxy = new Proxy.Proxy(realSubject);
Console.WriteLine("Client: Executing the same client code with a proxy:");
client.ClientCode(proxy);