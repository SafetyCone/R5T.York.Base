using System;


namespace R5T.York.Base
{
    public interface IHttpJsonSource
    {
        T Get<T>(string jsonUrlEndpoint);
    }
}
