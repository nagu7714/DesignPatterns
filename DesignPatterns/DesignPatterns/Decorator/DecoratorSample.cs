using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
   public interface IComponent
    {
        public void Operation();
    }

    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Plain String");
        }
    }

    /// <summary>
    /// The 'ConcreteDecoratorA' class
    /// </summary>
    public class ConcreteDecoratorA : IComponent
    {
        protected readonly IComponent _component;
        public ConcreteDecoratorA(IComponent component)
        {
            this._component = component;
        }
        public void Operation()
        {
            this._component.Operation();
            Console.WriteLine(" Docorated with A");
        }
    }

    /// <summary>
    /// The 'ConcreteDecoratorB' class
    /// </summary>
    public class ConcreteDecoratorB : IComponent
    {
        protected readonly IComponent _component;
        public ConcreteDecoratorB(IComponent component)
        {
            this._component = component;
        }
        public void Operation()
        {
            this._component.Operation();
            Console.WriteLine(" Docorated with B");
        }
    }
}
