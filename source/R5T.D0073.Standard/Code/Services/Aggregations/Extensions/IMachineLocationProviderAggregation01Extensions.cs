using System;


namespace R5T.D0073.Standard
{
    public static class IMachineLocationProviderAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IMachineLocationProviderAggregation01 other)
            where T : IMachineLocationProviderAggregation01
        {
            aggregation.DefaultMachineLocationProviderAction = other.DefaultMachineLocationProviderAction;
            aggregation.MachineLocationProviderAction = other.MachineLocationProviderAction;

            return aggregation;
        }
    }
}
