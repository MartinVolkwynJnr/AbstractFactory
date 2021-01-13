using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Objects
{
    class Rowlet : IGrassType
    {
        public void Beats(IWaterType h)
        {
            Console.WriteLine(this.GetType().Name +
                              " has type Advantage over " + h.GetType().Name);
        }
    }
}
