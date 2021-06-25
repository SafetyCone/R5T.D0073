using System;
using System.Threading.Tasks;


namespace R5T.D0073
{
    /// <summary>
    /// Stringly-typed machine location provider service.
    /// </summary>
    public interface IMachineLocationProvider
    {
        Task<string> GetMachineLocation();
    }
}
