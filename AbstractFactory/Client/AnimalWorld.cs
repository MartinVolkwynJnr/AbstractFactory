using AbstractFactory.Interfaces;

namespace AbstractFactory.Objects
{
    class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
    {
        IHerbivore herbivore;
        ICarnivore carnivore;
        T factory;

        public AnimalWorld()
        {
            // Create new continent factory
            factory = new T();

            // Factory creates carnivores and herbivores
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
