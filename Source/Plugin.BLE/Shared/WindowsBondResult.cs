using Plugin.BLE.Shared.Contracts.BondingWindows;

namespace Plugin.BLE.Abstractions
{
    /// <summary>
    /// The final results of the Bond Request
    /// </summary>
    /// <param name="status"> Result status. This depends on platforms cooperation in reporting.
    /// In addition to success, Windows and Android to a lesser extent may report information on failure </param>
    /// <param name="detail"> String representation of the <see cref="BondResult.Status" </param>
    /// <param name="protectionUsed"> The negotiated protection level (Authentication and or Encryption) used for communication with the remote device </param>
    public class WindowsBondResult(WindowsDevicePairingResultStatus status, string detail = "", WindowsDevicePairingProtectionLevel protectionUsed = WindowsDevicePairingProtectionLevel.None)
    {
        public WindowsDevicePairingResultStatus Status { get; } = status;
        public string Detail { get; } = detail;
        public WindowsDevicePairingProtectionLevel ProtectionUsed { get; } = protectionUsed;
    }
}
