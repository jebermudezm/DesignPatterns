// In this example, the Singleton class has a private constructor,
// which prevents external instantiation of the class.
// The class also has a public static property Instance,
// which returns the singleton instance of the class.

//The Instance property is implemented using the Lazy< T > class to ensure that
//the singleton instance is only created when it is first accessed, and that it is thread-safe.

//The DoSomething method is an example of a method that can be called on the singleton instance.

//To use the Singleton pattern, a client would simply call Singleton.
//Instance to get the singleton instance of the class, and then call any
//methods on that instance as needed:

using Singleton;

var singleton1 = Singleton1.Instance;
singleton1.DoSomething();


//In this example, the Singleton class also has a private constructor to prevent external
//instantiation. The class has a public static property Instance, which returns the singleton
//instance of the class.

//The Instance property uses a lazy initialization technique to ensure that the singleton
//instance is only created when it is first accessed. If the instance has not yet been created,
//the property creates a new instance of the Singleton class and assigns it to the
//_instance variable.

//The DoSomething method is an example of a method that can be called on the singleton instance.

//To use the Singleton pattern, a client would simply call Singleton.Instance to get the singleton
//instance of the class, and then call any methods on that instance as needed:

var singleton2 = Singleton2.Instance;
singleton2.DoSomething();