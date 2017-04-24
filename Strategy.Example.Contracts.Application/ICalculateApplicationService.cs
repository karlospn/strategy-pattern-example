using Strategy.Example.Contracts.Application.DTO;

namespace Strategy.Example.Contracts.Application
{
    public interface ICalculateApplicationService
    {
        int CalculateService(int data, TypeEnum type);
    }
}