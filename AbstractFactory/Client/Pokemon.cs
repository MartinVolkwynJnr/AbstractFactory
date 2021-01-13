using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class Pokemon<T> : IPokemon where T : IPokemonFactory, new()
    {
        IWaterType herbivore;
        IElectricType carnivore;
        T factory;

        public Pokemon()
        {
            // Create new continent factory
            factory = new T();

            // Factory creates carnivores and herbivores
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunType()
        {
            throw new System.NotImplementedException();
        }

        public void RunTypeStrongAgainst()
        {
            throw new System.NotImplementedException();
        }

        public void RunTypeWeakAgainst()
        {
            throw new System.NotImplementedException();
        }
    }
}
