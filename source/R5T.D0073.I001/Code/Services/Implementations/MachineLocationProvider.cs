using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using R5T.T0022;
using R5T.T0064;


namespace R5T.D0073.I001
{
    [ServiceImplementationMarker]
    public class MachineLocationProvider : IMachineLocationProvider, IServiceImplementation
    {
        private IConfiguration Configuration { get; }
        private IDefaultMachineLocationProvider DefaultMachineLocationProvider { get; }


        public MachineLocationProvider(
            IConfiguration configuration,
            IDefaultMachineLocationProvider defaultMachineLocationProvider)
        {
            this.Configuration = configuration;
            this.DefaultMachineLocationProvider = defaultMachineLocationProvider;
        }

        public async Task<string> GetMachineLocation()
        {
            var machineLocationWasFound = this.Configuration.GetValueOkIfNotExists(ConfigurationSectionNames.Instance.MachineLocation());
            if(machineLocationWasFound)
            {
                return machineLocationWasFound;
            }
            else
            {
                var defaultMachineLocation = await this.DefaultMachineLocationProvider.GetDefaultMachineLocation();
                return defaultMachineLocation;
            }
        }
    }
}
