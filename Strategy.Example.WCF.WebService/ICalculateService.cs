using System.Runtime.Serialization;
using System.ServiceModel;

namespace Strategy.Example.WCF.WebService
{
    [ServiceContract]
    public interface ICalculateService
    {
        [OperationContract]
        int? CalculateData(int data, TypeEnumDto type);
    }


    [DataContract]
    public enum TypeEnumDto
    {
        [EnumMember]
        TypeA,
        [EnumMember]
        TypeB,
        [EnumMember]
        TypeC
    }
}
