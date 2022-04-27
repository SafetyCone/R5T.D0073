using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0073
{
    [ServiceImplementationMarker]
    public class ConstructorBasedDefaultMachineLocationProvider : IDefaultMachineLocationProvider, IServiceImplementation
    {
        private string MachineLocation { get; }


        public ConstructorBasedDefaultMachineLocationProvider(
            [NotServiceComponent] string machineLocation)
        {
            this.MachineLocation = machineLocation;
        }

        public Task<string> GetDefaultMachineLocation()
        {
            return Task.FromResult(this.MachineLocation);
        }
    }
}
