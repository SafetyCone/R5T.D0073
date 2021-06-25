using System;
using System.Threading.Tasks;


namespace R5T.D0073.T002
{
    public class MachineLocations : IMachineLocations
    {
        public const string Local = "Local";
        public const string Remote = "Remote";


        #region Static

        public static MachineLocations Instance { get; } = new MachineLocations();


        public static bool IsLocal(string machineLocationValue)
        {
            var output = machineLocationValue == MachineLocations.Local;
            return output;
        }

        public static bool IsRemote(string machineLocationValue)
        {
            var output = machineLocationValue == MachineLocations.Remote;
            return output;
        }

        public static Task<T> Switch<T>(string machineLocationValue, Func<Task<T>> ifLocal, Func<Task<T>> ifRemote)
        {
            if(MachineLocations.IsLocal(machineLocationValue))
            {
                return ifLocal();
            }

            if(MachineLocations.IsRemote(machineLocationValue))
            {
                return ifRemote();
            }

            throw new ArgumentException($"Unknown machine location value: '{machineLocationValue}'. Must be either {MachineLocations.Local} or {MachineLocations.Remote}.", nameof(machineLocationValue));
        }

        #endregion
    }
}
