namespace AbstractFactory.Interfaces
{
    public interface IGroundType
    {
        void Type(IGroundType h);
        void StrongAgaintsType(IElectricType h);
        void WeakAgainstType(IGrassType h);
    }
}