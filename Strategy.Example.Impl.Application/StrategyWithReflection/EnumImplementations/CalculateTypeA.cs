using Strategy.Example.Impl.Application.StrategyWithReflection.EnumContracts;

namespace Strategy.Example.Impl.Application.StrategyWithReflection.EnumImplementations
{
    public class CalculateTypeA : ICalculateTypeA
    {
        public int Calculate(int data)
        {
            return data + 1;
        }
    }
}
