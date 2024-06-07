﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gemicle.MarketerTool.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MarketerToolContext>(opt =>
                opt.UseSqlite(configuration.GetConnectionString("MarketerToolDatabase")));
        }

        public static void InitializeDatabase(this IApplicationBuilder app)
        {
            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using var scope = scopeFactory.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<MarketerToolContext>();

            var pendingMigrations = context.Database.GetPendingMigrations().ToList();
            if (pendingMigrations.Any())
            {
                context.Database.Migrate();
            }
        }
    }
}