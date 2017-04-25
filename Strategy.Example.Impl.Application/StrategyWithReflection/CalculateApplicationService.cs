using System;
using Strategy.Example.Contracts.Application;
using Strategy.Example.Contracts.Application.DTO;

namespace Strategy.Example.Impl.Application.StrategyWithReflection
{
    public class CalculateApplicationService : ICalculateApplicationService
    {
        public int? CalculateService(int data, TypeEnum type)
        {
            throw new NotImplementedException();
        }
    }
}
