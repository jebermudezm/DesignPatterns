using AbstractFactory;

// Client code that uses the abstract factory
public class Client
{
    private IAbstractFactory _factory;
    private IProductA _productA;
    private IProductB _productB;

    public Client(IAbstractFactory factory)
    {
        _factory = factory;
        _productA = _factory.CreateProductA();
        _productB = _factory.CreateProductB();
    }

    public void Run()
    {
        Console.WriteLine("Created " + _productA.GetName() + " and " + _productB.GetName());
    }
}
