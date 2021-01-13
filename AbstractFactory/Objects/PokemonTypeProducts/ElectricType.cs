using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class ElectricType : IElectricType
    {
        public void Eat(IWaterType h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}
