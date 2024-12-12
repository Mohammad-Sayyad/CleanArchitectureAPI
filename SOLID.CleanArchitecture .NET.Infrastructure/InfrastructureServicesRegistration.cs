
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Email;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Logging;
using SOLID.CleanArchitecture_.NET.Application.Model.Email;
using SOLID.CleanArchitecture_.NET.Infrastructure.EmailService;
using SOLID.CleanArchitecture_.NET.Infrastructure.Logging;

namespace SOLID.CleanArchitecture_.NET.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            //services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
           
            return services;
        }
    }
}
