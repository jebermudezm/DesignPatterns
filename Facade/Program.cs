//In this example, the Computer class acts as a facade for the
//subsystems (i.e. the CPU, Memory, and HardDrive classes).
//The client code (i.e. the Main method) only interacts with the Computer facade
//to start the computer, and does not need to worry about the complexities
//of interacting with the individual subsystems.
//The Computer class takes care of all the details of starting the computer by calling
//the appropriate methods on the subsystems in the correct order.


using Facade;

Computer computer = new Computer();
computer.Start();
