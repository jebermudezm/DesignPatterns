namespace Singleton
{
    internal class Singleton2
    {
        private static Singleton2? _instance;

        public static Singleton2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton2();
                }

                return _instance;
            }
        }

        private Singleton2()
        {
            // Private constructor to prevent external instantiation
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }
}
