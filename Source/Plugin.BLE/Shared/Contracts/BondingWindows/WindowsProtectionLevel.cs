using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace Plugin.BLE.Shared.Contracts.BondingWindows
{
    public enum WindowsDevicePairingProtectionLevel
    {
        /// <summary>The default value. This should not be used.</summary>
        Default,
        /// <summary>Pair the device using no levels of protection.</summary>
        None,
        /// <summary>Pair the device using encryption.</summary>
        Encryption,
        /// <summary>Pair the device using encryption and authentication.</summary>
        EncryptionAndAuthentication,
    }
}
