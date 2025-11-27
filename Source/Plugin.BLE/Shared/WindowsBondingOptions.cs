using Plugin.BLE.Shared.Contracts.BondingWindows;

namespace Plugin.BLE.Abstractions
{
    public class WindowsBondingOptions
    {
        public WindowsDevicePairingKinds RequestedModes { get; }
        public WindowsDevicePairingProtectionLevel MinimumRequestedProtection { get; }

        public WindowsBondingOptions(WindowsDevicePairingKinds requestedModes, WindowsDevicePairingProtectionLevel minimumRequestedProtection)
        {
            RequestedModes = requestedModes;
            MinimumRequestedProtection = minimumRequestedProtection;
        }
    }
}
