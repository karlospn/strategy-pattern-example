using System;
using Strategy.Example.Contracts.Application;
using Strategy.Example.Contracts.Application.DTO;

namespace Strategy.Example.WCF.WebService
{
    public class CalculateService : ICalculateService
    {
        private readonly ICalculateApplicationService _calculateApplicationService;

        public CalculateService(ICalculateApplicationService calculateApplicationService)
        {
            _calculateApplicationService = calculateApplicationService;
        }
        public int? CalculateData(int data, TypeEnumDto type)
        {
           return _calculateApplicationService.CalculateService(data, (TypeEnum) type);
        }
    }
}
