using System;
using Strategy.Example.Contracts.Application.DTO;
using Strategy.Example.Impl.Application.StrategyWithDI.EnumContracts;

namespace Strategy.Example.Impl.Application.StrategyWithDI.EnumImplementations
{
    public class CalculateTypeC: ICalculate
    {
        public int Calculate(int data)
        {
            return data + 3;
        }

        public TypeEnum Type { get; set; } = TypeEnum.TypeC;
    }
}
