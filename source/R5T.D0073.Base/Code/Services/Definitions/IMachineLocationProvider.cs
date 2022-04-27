using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0073
{
    /// <summary>
    /// Stringly-typed machine location provider service.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IMachineLocationProvider : IServiceDefinition
    {
        Task<string> GetMachineLocation();
    }
}
