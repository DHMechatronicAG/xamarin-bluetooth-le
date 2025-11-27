using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace Plugin.BLE.Shared.Contracts.BondingWindows
{
    public enum WindowsDevicePairingResultStatus
    {
        /// <summary>The device object is now paired.</summary>
        Paired,
        /// <summary>The device object is not in a state where it can be paired.</summary>
        NotReadyToPair,
        /// <summary>The device object is not currently paired.</summary>
        NotPaired,
        /// <summary>The device object has already been paired.</summary>
        AlreadyPaired,
        /// <summary>The device object rejected the connection.</summary>
        ConnectionRejected,
        /// <summary>The device object indicated it cannot accept any more incoming connections.</summary>
        TooManyConnections,
        /// <summary>The device object indicated there was a hardware failure.</summary>
        HardwareFailure,
        /// <summary>The authentication process timed out before it could complete.</summary>
        AuthenticationTimeout,
        /// <summary>The authentication protocol is not supported, so the device is not paired.</summary>
        AuthenticationNotAllowed,
        /// <summary>Authentication failed, so the device is not paired. Either the device object or the application rejected the authentication.</summary>
        AuthenticationFailure,
        /// <summary>There are no network profiles for this device object to use.</summary>
        NoSupportedProfiles,
        /// <summary>The minimum level of protection is not supported by the device object or the application.</summary>
        ProtectionLevelCouldNotBeMet,
        /// <summary>Your application does not have the appropriate permissions level to pair the device object.</summary>
        AccessDenied,
        /// <summary>The ceremony data was incorrect.</summary>
        InvalidCeremonyData,
        /// <summary>The pairing action was canceled before completion.</summary>
        PairingCanceled,
        /// <summary>The device object is already attempting to pair or unpair.</summary>
        OperationAlreadyInProgress,
        /// <summary>Either the event handler wasn't registered or a required DevicePairingKinds was not supported.</summary>
        RequiredHandlerNotRegistered,
        /// <summary>The application handler rejected the pairing.</summary>
        RejectedByHandler,
        /// <summary>The remove device already has an association.</summary>
        RemoteDeviceHasAssociation,
        /// <summary>An unknown failure occurred.</summary>
        Failed,
    }
}
