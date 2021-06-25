using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0073.I001;


namespace R5T.D0073.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static MachineLocationProviderAggregation01 AddMachineLocationProvider(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction)
        {
            // Level 0.
            var defaultMachineLocationProviderAction = services.AddLocalDefaultMachineLocationProviderAction();

            // Level 1.
            var machineLocationProvider = services.AddMachineLocationProviderAction(
                configurationAction,
                defaultMachineLocationProviderAction);

            return new MachineLocationProviderAggregation01
            {
                DefaultMachineLocationProviderAction = defaultMachineLocationProviderAction,
                MachineLocationProviderAction = machineLocationProvider
            };
        }
    }
}
