namespace Adapter
{
    // Client code
    internal class Client
    {
        public void Run()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            target.Request();
        }
    }
}
