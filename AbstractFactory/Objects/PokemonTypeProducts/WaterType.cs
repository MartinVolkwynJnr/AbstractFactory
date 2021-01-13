using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class WaterType : IElectricType
    {
        public void Eat(IWaterType h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}
