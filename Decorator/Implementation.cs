namespace Decorator
{
    using System;

    // The interface for the component to be decorated
    public interface IShape
    {
        void Draw();
    }

    // The concrete implementation of the component
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    // The abstract decorator class that wraps around the component
    public abstract class ShapeDecorator : IShape
    {
        private IShape _shape;

        public ShapeDecorator(IShape shape)
        {
            _shape = shape;
        }

        public virtual void Draw()
        {
            _shape.Draw();
        }
    }

    // The concrete decorator that adds functionality to the component
    public class RedBorderDecorator : ShapeDecorator
    {
        public RedBorderDecorator(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Adding a red border.");
        }
    }
}
