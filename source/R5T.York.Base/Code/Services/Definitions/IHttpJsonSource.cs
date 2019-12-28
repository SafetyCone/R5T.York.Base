using System;
using System.Threading.Tasks;


namespace R5T.York
{
    public interface IHttpJsonSource
    {
        Task<T> GetAsync<T>(string jsonUrlEndpoint);
    }
}
