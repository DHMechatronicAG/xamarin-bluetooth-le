using System;
using Windows.Devices.Enumeration;
using Plugin.BLE.Shared.Contracts.BondingWindows;

namespace Plugin.BLE.Extensions;

internal static class DeviceBondStatusExtension
{
	public static WindowsDevicePairingResultStatus XPlatformParigingResultStatus(this DevicePairingResultStatus parigingResultStatus)
	{
		switch (parigingResultStatus)
		{
			case DevicePairingResultStatus.Paired:
				return WindowsDevicePairingResultStatus.Paired;

			case DevicePairingResultStatus.NotPaired:
                return WindowsDevicePairingResultStatus.NotPaired;

            case DevicePairingResultStatus.Failed:
				return WindowsDevicePairingResultStatus.Failed;

			case DevicePairingResultStatus.NotReadyToPair:
                return WindowsDevicePairingResultStatus.NotReadyToPair;

            case DevicePairingResultStatus.AlreadyPaired:
                return WindowsDevicePairingResultStatus.AlreadyPaired;

            case DevicePairingResultStatus.ConnectionRejected:
                return WindowsDevicePairingResultStatus.ConnectionRejected;

            case DevicePairingResultStatus.TooManyConnections:
                return WindowsDevicePairingResultStatus.TooManyConnections;

            case DevicePairingResultStatus.HardwareFailure:
                return WindowsDevicePairingResultStatus.HardwareFailure;

            case DevicePairingResultStatus.AuthenticationTimeout:
                return WindowsDevicePairingResultStatus.AuthenticationTimeout;

            case DevicePairingResultStatus.AuthenticationNotAllowed:
                return WindowsDevicePairingResultStatus.AuthenticationNotAllowed;

            case DevicePairingResultStatus.AuthenticationFailure:
                return WindowsDevicePairingResultStatus.AuthenticationFailure;

            case DevicePairingResultStatus.NoSupportedProfiles:
                return WindowsDevicePairingResultStatus.NoSupportedProfiles;

            case DevicePairingResultStatus.ProtectionLevelCouldNotBeMet:
                return WindowsDevicePairingResultStatus.ProtectionLevelCouldNotBeMet;

            case DevicePairingResultStatus.AccessDenied:
                return WindowsDevicePairingResultStatus.AccessDenied;

            case DevicePairingResultStatus.InvalidCeremonyData:
                return WindowsDevicePairingResultStatus.InvalidCeremonyData;

            case DevicePairingResultStatus.PairingCanceled:
                return WindowsDevicePairingResultStatus.PairingCanceled;

            case DevicePairingResultStatus.OperationAlreadyInProgress:
                return WindowsDevicePairingResultStatus.OperationAlreadyInProgress;

            case DevicePairingResultStatus.RequiredHandlerNotRegistered:
                return WindowsDevicePairingResultStatus.RequiredHandlerNotRegistered;

            case DevicePairingResultStatus.RejectedByHandler:
                return WindowsDevicePairingResultStatus.RejectedByHandler;

            case DevicePairingResultStatus.RemoteDeviceHasAssociation:
                return WindowsDevicePairingResultStatus.RemoteDeviceHasAssociation;
                
            default: throw new ArgumentOutOfRangeException(nameof(parigingResultStatus), parigingResultStatus, null);
		}
	}
}
