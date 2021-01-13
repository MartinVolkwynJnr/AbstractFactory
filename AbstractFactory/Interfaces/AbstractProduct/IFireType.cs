namespace AbstractFactory.Interfaces
{
    public interface IFireType
    {
        void Type(IFireType h);
        void StrongAgaintsType(IWaterType h);
        void WeakAgainstType(IGroundType h);
    }
}