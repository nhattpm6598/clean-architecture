using BE.Eco.PaymentProcessing.Domain.Constants.Enums;
using BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig.Connection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig
{
    public static class DependecyInjection
    {
        public static IServiceCollection RegisterSql(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionDict = new Dictionary<DatabaseInstance, string?>
            {
                { DatabaseInstance.ECO_MAT, configuration.GetConnectionString(nameof(DatabaseInstance.ECO_MAT)) },
                { DatabaseInstance.ECO_MER, configuration.GetConnectionString(nameof(DatabaseInstance.ECO_MER)) }
            };

            // Inject this dict
            services.AddSingleton<IDictionary<DatabaseInstance, string?>>(connectionDict);

            // Inject the factory
            services.AddTransient<IDBMultiConnectionFactory, DapperDBMultiConnectionFactory>();
            
            return services;
        }
    }
}
