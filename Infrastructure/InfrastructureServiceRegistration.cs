using System;
using Application.Contracts;
using Infrastructure.DataBase.Repositorys;
using Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
	public static class InfrastructureServiceRegistration
	{
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMailServices, MailServices>();
            services.AddScoped<ICarRepository, CarRepository>();
            return services;
        }
    }
}

