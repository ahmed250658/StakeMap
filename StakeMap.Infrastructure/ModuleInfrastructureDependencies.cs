using Microsoft.Extensions.DependencyInjection;
using StakeMap.Infrastructure.Repository.Abstracts;
using StakeMap.Infrastructure.Repository.Implements;


namespace Wasted_Food.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IRefreshTokenReposatory, RefreshTokenReposatory>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IReportRepository, ReportRepository>();
            services.AddTransient<IDashboardMetricsRepository, DashboardMetricsRepository>();

            return services;
        }

    }
}
