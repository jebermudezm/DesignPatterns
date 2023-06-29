namespace Prototype
{
    internal class Client
    {
        private IPrototype _prototype;

        public Client(IPrototype prototype)
        {
            _prototype = prototype;
        }

        public void Run()
        {
            // Clone the prototype to create a new object
            IPrototype newObject = _prototype.Clone();

            // Output the details of the original object and the new object
            Console.WriteLine("Original object:");
            OutputDetails(_prototype);
            Console.WriteLine("New object:");
            OutputDetails(newObject);
        }

        private void OutputDetails(IPrototype prototype)
        {
            if (prototype is ConcretePrototype1)
            {
                Console.WriteLine("Id: " + ((ConcretePrototype1)prototype).Id);
            }
            else if (prototype is ConcretePrototype2)
            {
                Console.WriteLine("Name: " + ((ConcretePrototype2)prototype).Name);
            }
        }
    }
}
