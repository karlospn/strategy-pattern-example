using System;
using System.Collections.Generic;
using Strategy.Example.Contracts.Application.DTO;
using Strategy.Example.Impl.Application.StrategyWithReflection.EnumContracts;

namespace Strategy.Example.Impl.Application.StrategyWithReflection.Dictionary
{
    public static class DictionaryConfiguration
    {
        public static Dictionary<TypeEnum, Type> DictImplementation = new Dictionary<TypeEnum, Type>
        {
            {TypeEnum.TypeA, typeof(ICalculateTypeA)},
            {TypeEnum.TypeB, typeof(ICalculateTypeB)},
            {TypeEnum.TypeC, typeof(ICalculateTypeC)}
        };
    }
}
