using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Objects
{
    class Leafeon : IGrassType
    {
        public void Beats(IWaterType h)
        {
            Console.WriteLine(this.GetType().Name +
                              " has type Advantage over " + h.GetType().Name);
        }
    }
}
