namespace SOLID.CleanArchitecture_.NET.BlazorApp.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }
    }
}
