using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory.Objects
{
    class Litten : IFireType
    {
        public void Beats(IGrassType h)
        {
            Console.WriteLine(this.GetType().Name +
                              " has type Advantage over " + h.GetType().Name);
        }
    }
}
