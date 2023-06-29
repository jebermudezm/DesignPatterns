namespace Proxy
{
    using System;

    // The Subject interface declares common operations for both RealSubject and
    // the Proxy. As long as the client works with RealSubject using this interface,
    // you'll be able to pass it a proxy instead of a real subject.
    interface ISubject
    {
        void Request();
    }

    // The RealSubject contains some core business logic. Usually, RealSubjects are
    // capable of doing some useful work which may also be very slow or sensitive -
    // e.g. correcting input data. A Proxy can solve these issues without any changes
    // to the RealSubject's code.
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }

    // The Proxy has an interface identical to the RealSubject.
    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        // The most common usage of the Proxy pattern is lazy loading. This means
        // delaying the creation of an object until the first time it's needed.
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject = new RealSubject();
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        private bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        private void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }

    // The client code is supposed to work with all objects (both subjects and
    // proxies) via the Subject interface in order to support both real subjects
    // and proxies. In real life, however, clients mostly work with their real
    // subjects directly. In this case, to implement the pattern more easily, you
    // can extend your proxy from the real subject's class.
    class Client
    {
        public void ClientCode(ISubject subject)
        {
            // ...

            subject.Request();

            // ...
        }
    }
}
