using System;
using System.Threading.Tasks;


namespace R5T.D0073
{
    /// <summary>
    /// Provides a default machine location value when none is available.
    /// </summary>
    public interface IDefaultMachineLocationProvider
    {
        Task<string> GetDefaultMachineLocation();
    }
}
