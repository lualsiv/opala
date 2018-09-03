﻿using Opala.Core.Domain.Adapters;
using Opala.Infra.NotificationAdapter;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NotificationAdapterServiceCollectionExtensions
    {
        public static IServiceCollection AddNotificationAdapter(this IServiceCollection services, NotificationAdapterConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<INotificationAdapter, NotificationAdapter>();
            services.AddSingleton(configuration);

            return services;
        }
    }
}