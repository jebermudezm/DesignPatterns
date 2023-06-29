namespace Adapter
{
    // Adapter class
    internal class Adapter : ITarget
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
