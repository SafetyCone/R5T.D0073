using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0073
{
    /// <summary>
    /// Provides a default machine location value when none is available.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IDefaultMachineLocationProvider : IServiceDefinition
    {
        Task<string> GetDefaultMachineLocation();
    }
}
