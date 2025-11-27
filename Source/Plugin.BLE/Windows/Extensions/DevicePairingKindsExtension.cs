using System;
using Windows.Devices.Enumeration;
using Plugin.BLE.Shared.Contracts.BondingWindows;

namespace Plugin.BLE.Extensions;

internal static class DevicePairingKindsExtension
{
	public static DevicePairingKinds ToNative(this WindowsDevicePairingKinds devaicePairingKinds)
	{
		switch (devaicePairingKinds)
		{
			case WindowsDevicePairingKinds.None:
				return DevicePairingKinds.None;

            case WindowsDevicePairingKinds.ConfirmOnly:
                return DevicePairingKinds.ConfirmOnly;

            case WindowsDevicePairingKinds.DisplayPin:
                return DevicePairingKinds.DisplayPin;

            case WindowsDevicePairingKinds.ProvidePin:
                return DevicePairingKinds.ProvidePin;

            case WindowsDevicePairingKinds.ConfirmPinMatch:
                return DevicePairingKinds.ConfirmPinMatch;

#if WINDOWS10_0_18362_0_OR_GREATER
            case WindowsDevicePairingKinds.ProvidePasswordCredential:
                return DevicePairingKinds.ProvidePasswordCredential;
#endif
                
            default: throw new ArgumentOutOfRangeException(nameof(devaicePairingKinds), devaicePairingKinds, null);
		}
	}
}
