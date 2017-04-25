using Strategy.Example.Contracts.Application.DTO;
using Strategy.Example.Impl.Application.StrategyWithDI.EnumContracts;

namespace Strategy.Example.Impl.Application.StrategyWithDI.EnumImplementations
{
    public class CalculateTypeA : ICalculate
    {
        public int Calculate(int data)
        {
            return data + 1;
        }

        public TypeEnum Type { get; set; } = TypeEnum.TypeA;
    }
}