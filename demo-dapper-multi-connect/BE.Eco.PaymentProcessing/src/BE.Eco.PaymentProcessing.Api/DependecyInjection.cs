using BE.Eco.PaymentProcessing.Application;
using BE.Eco.PaymentProcessing.Domain;
using BE.Eco.PaymentProcessing.Infrastructure;

namespace BE.Eco.PaymentProcessing.Api
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();

            services.AddDomain(configuration);

            services.AddInfrastructure(configuration);

            services.AddApplication(configuration);

            return services;
        }
    }
}
