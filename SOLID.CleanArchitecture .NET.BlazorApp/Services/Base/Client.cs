using System.Net.Http;

namespace SOLID.CleanArchitecture_.NET.BlazorApp.Services.Base
{
   
        public partial class Client : IClient
        {
            public HttpClient HttpClient
            {
                get
                {
                    return _httpClient;
                }
            }
    }
}
