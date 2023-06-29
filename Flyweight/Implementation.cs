namespace Flyweight
{
    using System;
    using System.Collections.Generic;

    // Flyweight interface
    public interface ICar
    {
        void Drive(int speed);
    }

    // Concrete flyweight
    public class Car : ICar
    {
        private string brand;
        private string model;

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public void Drive(int speed)
        {
            Console.WriteLine($"Driving {brand} {model} at {speed} km/h");
        }
    }

    // Flyweight factory
    public class CarFactory
    {
        private Dictionary<string, ICar> cars = new Dictionary<string, ICar>();

        public ICar GetCar(string brand, string model)
        {
            string key = $"{brand}-{model}";

            if (!cars.ContainsKey(key))
            {
                cars[key] = new Car(brand, model);
            }

            return cars[key];
        }
    }

    // Client
    public class Client
    {
        public void Run()
        {
            CarFactory factory = new CarFactory();

            ICar car1 = factory.GetCar("Toyota", "Corolla");
            ICar car2 = factory.GetCar("Toyota", "Corolla");
            ICar car3 = factory.GetCar("Toyota", "Camry");

            car1.Drive(100);
            car2.Drive(120);
            car3.Drive(150);
        }
    }
}
