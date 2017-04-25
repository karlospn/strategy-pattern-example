using System;
using System.Collections.Generic;
using System.Linq;
using Strategy.Example.Contracts.Application;
using Strategy.Example.Contracts.Application.DTO;
using Strategy.Example.Impl.Application.StrategyWithDI.EnumContracts;

namespace Strategy.Example.Impl.Application.StrategyWithDI
{
    public class CalculateApplicationService : ICalculateApplicationService
    {
        private readonly IEnumerable<ICalculate> _calculators;

        public CalculateApplicationService(IEnumerable<ICalculate> calculators)
        {
            _calculators = calculators;
        }

        public int? CalculateService(int data, TypeEnum type)
        {
            var implementation = this._calculators.FirstOrDefault(x => x.Type == type);
            return implementation?.Calculate(data);
        }
    }
}
