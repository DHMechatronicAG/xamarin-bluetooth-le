using System;
using Windows.Devices.Enumeration;
using Plugin.BLE.Shared.Contracts.BondingWindows;

namespace Plugin.BLE.Extensions;

internal static class WindowsDevicePairingProtectionLevelExtension
{
	public static WindowsDevicePairingProtectionLevel XPlatformParigingResultStatus(this DevicePairingProtectionLevel devicePairingProtectionLevel)
	{
		switch (devicePairingProtectionLevel)
		{
			case DevicePairingProtectionLevel.Default:
				return WindowsDevicePairingProtectionLevel.Default;
                
            case DevicePairingProtectionLevel.None:
                return WindowsDevicePairingProtectionLevel.None;

            case DevicePairingProtectionLevel.Encryption:
                return WindowsDevicePairingProtectionLevel.Encryption;

            case DevicePairingProtectionLevel.EncryptionAndAuthentication:
                return WindowsDevicePairingProtectionLevel.EncryptionAndAuthentication;
                
            default: throw new ArgumentOutOfRangeException(nameof(devicePairingProtectionLevel), devicePairingProtectionLevel, null);
		}
	}
}
