using System;


namespace R5T.D0073.T002
{
    public static class IMachineLocationsExtensions
    {
#pragma warning disable IDE0060 // Remove unused parameter

        public static string Local(this IMachineLocations machineLocations)
        {
            return MachineLocations.Local;
        }

        public static string Remote(this IMachineLocations machineLocations)
        {
            return MachineLocations.Remote;
        }

#pragma warning restore IDE0060 // Remove unused parameter
    }
}
