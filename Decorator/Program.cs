//In this example, we have an interface IShape that represents the component to be decorated.
//The Circle class is a concrete implementation of this component.

//We then have an abstract ShapeDecorator class that wraps around the component.
//This class also implements the IShape interface, so it can be used interchangeably
//with the component itself. The RedBorderDecorator class is a concrete decorator that
//adds a red border to the component.

//Finally, we have the client code that creates a concrete component,
//decorates it with the RedBorderDecorator, and draws the decorated component.
//The output of this program would be:
//Drawing a circle.
//Adding a red border.

//This demonstrates how the decorator pattern can be used to add functionality
//to a component without changing its interface or implementation.


using Decorator;
// Creating a concrete component
IShape circle = new Circle();

// Decorating the component with the RedBorderDecorator
IShape redCircle = new RedBorderDecorator(circle);

// Drawing the decorated component
redCircle.Draw();

Console.ReadKey();