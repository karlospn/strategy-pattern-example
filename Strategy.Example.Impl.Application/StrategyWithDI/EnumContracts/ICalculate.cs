using Strategy.Example.Contracts.Application.DTO;

namespace Strategy.Example.Impl.Application.StrategyWithDI.EnumContracts
{
    public interface ICalculate
    {
        int Calculate(int data);
        TypeEnum Type { get; set; }
    }
}