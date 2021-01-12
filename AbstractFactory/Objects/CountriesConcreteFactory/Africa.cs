using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Africa : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Wildebees();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
