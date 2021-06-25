using System;
using System.Threading.Tasks;

namespace R5T.D0073
{
    public class ConstructorBasedDefaultMachineLocationProvider : IDefaultMachineLocationProvider
    {
        private string MachineLocation { get; }


        public ConstructorBasedDefaultMachineLocationProvider(
            string machineLocation)
        {
            this.MachineLocation = machineLocation;
        }

        public Task<string> GetDefaultMachineLocation()
        {
            return Task.FromResult(this.MachineLocation);
        }
    }
}
