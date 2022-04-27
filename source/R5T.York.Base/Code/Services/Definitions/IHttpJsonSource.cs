using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.York
{[ServiceDefinitionMarker]
    public interface IHttpJsonSource:IServiceDefinition
    {
        Task<T> GetAsync<T>(string jsonUrlEndpoint);
    }
}
