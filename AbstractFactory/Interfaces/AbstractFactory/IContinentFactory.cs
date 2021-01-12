namespace AbstractFactory.Interfaces
{
    public interface IContinentFactory
    {
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }
}