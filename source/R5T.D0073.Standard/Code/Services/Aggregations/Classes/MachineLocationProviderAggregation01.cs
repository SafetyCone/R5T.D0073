﻿using System;

using R5T.Dacia;


namespace R5T.D0073.Standard
{
    public class MachineLocationProviderAggregation01 : IMachineLocationProviderAggregation01
    {
        public IServiceAction<IDefaultMachineLocationProvider> DefaultMachineLocationProviderAction { get; set; }
        public IServiceAction<IMachineLocationProvider> MachineLocationProviderAction { get; set; }
    }
}
