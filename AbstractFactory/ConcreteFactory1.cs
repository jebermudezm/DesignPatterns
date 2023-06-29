namespace AbstractFactory
{
    // Concrete factory 1
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
