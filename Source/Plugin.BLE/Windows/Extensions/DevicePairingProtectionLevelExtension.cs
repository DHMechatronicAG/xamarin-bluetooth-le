using System;
using Windows.Devices.Enumeration;
using Plugin.BLE.Shared.Contracts.BondingWindows;

namespace Plugin.BLE.Extensions;

internal static class DevicePairingProtectionLevelExtension
{
	public static DevicePairingProtectionLevel ToNative(this WindowsDevicePairingProtectionLevel devicePairingProtectionLevel)
	{
		switch (devicePairingProtectionLevel)
		{
			case WindowsDevicePairingProtectionLevel.Default:
				return DevicePairingProtectionLevel.Default;
                
            case WindowsDevicePairingProtectionLevel.None:
                return DevicePairingProtectionLevel.None;

            case WindowsDevicePairingProtectionLevel.Encryption:
                return DevicePairingProtectionLevel.Encryption;

            case WindowsDevicePairingProtectionLevel.EncryptionAndAuthentication:
                return DevicePairingProtectionLevel.EncryptionAndAuthentication;
                
            default: throw new ArgumentOutOfRangeException(nameof(devicePairingProtectionLevel), devicePairingProtectionLevel, null);
		}
	}
}
