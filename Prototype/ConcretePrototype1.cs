namespace Prototype
{
    internal class ConcretePrototype1 : IPrototype
    {
        public int Id { get; private set; }

        public ConcretePrototype1(int id)
        {
            Id = id;
        }

        public IPrototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }
}
