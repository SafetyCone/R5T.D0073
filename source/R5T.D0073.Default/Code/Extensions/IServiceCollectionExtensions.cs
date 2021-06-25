using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0073
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LocalDefaultMachineLocationProvider"/> implementation of <see cref="IDefaultMachineLocationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddLocalDefaultMachineLocationProvider(this IServiceCollection services)
        {
            services.AddSingleton<IDefaultMachineLocationProvider, LocalDefaultMachineLocationProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="LocalDefaultMachineLocationProvider"/> implementation of <see cref="IDefaultMachineLocationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDefaultMachineLocationProvider> AddLocalDefaultMachineLocationProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IDefaultMachineLocationProvider>(() => services.AddLocalDefaultMachineLocationProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedDefaultMachineLocationProvider"/> implementation of <see cref="IDefaultMachineLocationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedDefaultMachineLocationProvider(this IServiceCollection services,
            string machineLocation)
        {
            services.AddSingleton<IDefaultMachineLocationProvider>(new ConstructorBasedDefaultMachineLocationProvider(machineLocation));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedDefaultMachineLocationProvider"/> implementation of <see cref="IDefaultMachineLocationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDefaultMachineLocationProvider> AddConstructorBasedDefaultMachineLocationProviderAction(this IServiceCollection services,
            string machineLocation)
        {
            var serviceAction = ServiceAction.New<IDefaultMachineLocationProvider>(() => services.AddConstructorBasedDefaultMachineLocationProvider(
                machineLocation));

            return serviceAction;
        }
    }
}
