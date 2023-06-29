namespace FactoryMethod
{
    internal class ConcreteFactory1 : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcretProduct1();
        }
    }
}
