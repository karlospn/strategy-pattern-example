using System.Reflection;
using Strategy.Example.Contracts.Application;
using Strategy.Example.Contracts.Application.DTO;
using Strategy.Example.Impl.Application.StrategyWithReflection.Dictionary;
using Strategy.Example.Impl.Application.StrategyWithReflection.EnumContracts;

namespace Strategy.Example.Impl.Application.StrategyWithReflection
{
    public class CalculateApplicationService : ICalculateApplicationService
    {
        public int? CalculateService(int data, TypeEnum enumType)
        {
            var _interface = DictionaryConfiguration.DictImplementation[enumType];
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (_interface.IsAssignableFrom(type) && !type.IsInterface)
                {
                    var instance = (ICalculateBase)assembly.CreateInstance(type.FullName, false);
                    return instance?.Calculate(data);
                }
            }
            return null;
        }
    }
}
