using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Wolf : ICarnivore
    {
        public void Eat(IHerbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}
