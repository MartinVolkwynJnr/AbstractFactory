using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Vaporeon : IWaterType
    {
        public void Beats(IFireType h)
        {
            Console.WriteLine(this.GetType().Name +
                              " has type Advantage over " + h.GetType().Name);
        }
    }
}
