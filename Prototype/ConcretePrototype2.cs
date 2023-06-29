namespace Prototype
{
    internal class ConcretePrototype2 : IPrototype
    {
        public string Name { get; private set; }

        public ConcretePrototype2(string name)
        {
            Name = name;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype2(Name);
        }
    }
}
