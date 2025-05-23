using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using StakeMap.Core.Behavior;
using StakeMap.Core.Service.Abstracts;
using StakeMap.Core.Service.Implementions;

namespace StakeMap.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            // Configration Of Mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            // Configration Of AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            //
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IReportService, ReportService>();
            services.AddTransient<IDashboardMetricService, DashboardMetricService>();
            services.AddTransient<IEmailService, EmailService>();
            return services;
        }
    }
}
