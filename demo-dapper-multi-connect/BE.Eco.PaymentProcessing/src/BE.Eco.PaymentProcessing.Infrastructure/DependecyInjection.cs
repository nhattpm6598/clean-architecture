using BE.Eco.PaymentProcessing.Application.Repositories.Common;
using BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig;
using BE.Eco.PaymentProcessing.Infrastructure.Repositories.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BE.Eco.PaymentProcessing.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterSql(configuration);

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}