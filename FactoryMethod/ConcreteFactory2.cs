namespace FactoryMethod
{
    internal class ConcreteFactory2 : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcretProduct2();
        }
    }
}
