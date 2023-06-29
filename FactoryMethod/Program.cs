
using FactoryMethod;

Factory factory = new ConcreteFactory1();
Product product = factory.CreateProduct();
product.Operation();

factory = new ConcreteFactory2();
product = factory.CreateProduct();
product.Operation();

