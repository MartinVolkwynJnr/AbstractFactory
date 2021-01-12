using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Lion : ICarnivore
    {
        public void Eat(IHerbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}
