using Strategy.Example.Contracts.Application.DTO;
using Strategy.Example.Impl.Application.StrategyWithDI.EnumContracts;

namespace Strategy.Example.Impl.Application.StrategyWithDI.EnumImplementations
{
    public class CalculateTypeB : ICalculate
    {
        public int Calculate(int data)
        {
            return data + 2;
        }

        public TypeEnum Type { get; set; } = TypeEnum.TypeB;
    }
}
