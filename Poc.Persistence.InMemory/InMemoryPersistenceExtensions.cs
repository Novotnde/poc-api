using Microsoft.Extensions.DependencyInjection;
using Poc.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.Persistence.InMemory
{
    public static class InMemoryPersistenceExtensions
    {  // pomocna metoda pro registraci konkretni implementace
        public static IServiceCollection AddInMemoryPersitence(this IServiceCollection services)
        {
            services.AddTransient<IUserPersistence, UserPersistence>();

            return services;
        }

    }
}
