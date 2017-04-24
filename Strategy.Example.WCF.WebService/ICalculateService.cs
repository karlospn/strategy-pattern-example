using System.Runtime.Serialization;
using System.ServiceModel;

namespace Strategy.Example.WCF.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculateService
    {
        [OperationContract]
        int CalculateData(int data, TypeEnumDto type);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
