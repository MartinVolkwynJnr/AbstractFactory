using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Eevee : IPokemonFactory
    {
        public IWaterType CreateHerbivore()
        {
            return new FireType();
        }

        public IElectricType CreateCarnivore()
        {
            return new ElectricType();
        }

        public IWaterType CreateType()
        {
            return new NormalType();
        }

        public IElectricType CreateStrongAgainstType()
        {
            return null;
        }

        public IElectricType CreateWeakAgainstType()
        {
            return new GrassType();
        }
    }
}
