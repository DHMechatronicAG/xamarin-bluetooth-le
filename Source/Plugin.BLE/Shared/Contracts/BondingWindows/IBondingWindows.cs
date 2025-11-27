using System.Threading;
using System.Threading.Tasks;
using Plugin.BLE.Abstractions;
using Plugin.BLE.Abstractions.Contracts;

namespace Plugin.BLE.Contracts.BondingWindows
{
    /// <summary>
    /// The bluetooth LE Adapter.
    /// </summary>
    public interface IBondingWindows
    {
        Task<WindowsBondResult> BondAsync(IDevice device, WindowsBondingOptions options, CancellationToken cancellationToken = default);
    }
}
