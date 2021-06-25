using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0073.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="MachineLocationProvider"/> implementation of <see cref="IMachineLocationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddMachineLocationProvider(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IDefaultMachineLocationProvider> defaultMachineLocationProviderAction)
        {
            services.AddSingleton<IMachineLocationProvider, MachineLocationProvider>()
                .Run(configurationAction)
                .Run(defaultMachineLocationProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="MachineLocationProvider"/> implementation of <see cref="IMachineLocationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IMachineLocationProvider> AddMachineLocationProviderAction(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IDefaultMachineLocationProvider> defaultMachineLocationProviderAction)
        {
            var serviceAction = ServiceAction.New<IMachineLocationProvider>(() => services.AddMachineLocationProvider(
                configurationAction,
                defaultMachineLocationProviderAction));

            return serviceAction;
        }
    }
}
