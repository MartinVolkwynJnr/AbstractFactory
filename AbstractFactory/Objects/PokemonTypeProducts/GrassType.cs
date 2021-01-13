using System;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class GrassType : IGrassType
    {
        public void StrongAgaintsType(IGroundType h)
        {
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }

        public void Type(IGrassType h)
        {
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }

        public void WeakAgainstType(IFireType h)
        {
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}
