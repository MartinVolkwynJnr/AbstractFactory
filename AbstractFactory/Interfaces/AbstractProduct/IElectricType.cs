namespace AbstractFactory.Interfaces
{
    public interface IElectricType
    {
        void Type(IElectricType h);
        void StrongAgaintsType(IWaterType h);
        void WeakAgainstType(IGroundType h);
    }
}