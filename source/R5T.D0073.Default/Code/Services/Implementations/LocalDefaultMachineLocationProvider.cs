﻿using System;
using System.Threading.Tasks;

using R5T.D0073.T002;
using R5T.T0064;


namespace R5T.D0073
{
    /// <summary>
    /// Always return the local machine location as a default in case there is no other machine location available.
    /// </summary>
    [ServiceImplementationMarker]
    public class LocalDefaultMachineLocationProvider : IDefaultMachineLocationProvider, IServiceImplementation
    {
        public Task<string> GetDefaultMachineLocation()
        {
            var localMachineLocation = MachineLocations.Instance.Local();

            return Task.FromResult(localMachineLocation);
        }
    }
}
