﻿using Plugin.BLE;
using Plugin.BLE.Abstractions;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE.Abstractions.Extensions;
using Plugin.BLE.Extensions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;

namespace BLE.Client.WinConsole
{
    internal class BleDemo
    {
        private readonly IBluetoothLE bluetoothLE;
        private readonly IAdapter adapter;
        private readonly Action<string, object[]>? writer;
        private readonly List<IDevice> discoveredDevices;
        private readonly IDictionary<Guid, IDevice> connectedDevices;

        public BleDemo(Action<string, object[]>? writer = null)
        {
            discoveredDevices = new List<IDevice>();
            connectedDevices = new ConcurrentDictionary<Guid, IDevice>();
            bluetoothLE = CrossBluetoothLE.Current;
            adapter = CrossBluetoothLE.Current.Adapter;
            this.writer = writer;
        }        

        private void Write(string format, params object[] args)
        {
            writer?.Invoke(format, args);
        }

        public IDevice ConnectToKnown(Guid id)
        {
            IDevice dev = adapter.ConnectToKnownDeviceAsync(id).Result;
            connectedDevices[id] = dev;
            return dev;
        }

        public IDevice ConnectToKnown(string bleaddress)
        {
            var id = bleaddress.ToBleDeviceGuid();
            return ConnectToKnown(id);
        }

        public async Task DoTheScanning(ScanMode scanMode = ScanMode.LowPower, int time_ms = 2000)
        {

            if (!bluetoothLE.IsOn)
            {
                Write("Bluetooth is not On - it is {0}", bluetoothLE.State);
                return;
            }
            Write("Bluetooth is on");
            Write("Scanning now for " + time_ms + " ms...");            
            var cancellationTokenSource = new CancellationTokenSource(time_ms);
            discoveredDevices.Clear();

            adapter.DeviceDiscovered += (s, a) =>
            {
                var dev = a.Device;
                Write("DeviceDiscovered: {0} with Name = {1}", dev.Id.ToHexBleAddress(), dev.Name);
                discoveredDevices.Add(a.Device);
            };
            adapter.ScanMode = scanMode;
            await adapter.StartScanningForDevicesAsync(cancellationToken: cancellationTokenSource.Token);

        }

        void WriteAdvertisementRecords(IDevice device)
        {
            if (device.AdvertisementRecords is null)
            {
                Write("{0} {1} has no AdvertisementRecords...", device.Name, device.State);
                return;
            }
            Write("{0} {1} with {2} AdvertisementRecords", device.Name, device.State, device.AdvertisementRecords.Count);
            foreach (var ar in device.AdvertisementRecords)
            {
                switch (ar.Type)
                {
                    case AdvertisementRecordType.CompleteLocalName:
                        Write(ar.ToString() + " = " + Encoding.UTF8.GetString(ar.Data));
                        break;
                    default:
                        Write(ar.ToString());
                        break;
                }
            }
        }

        public async Task ConnectTest(string name)
        {
            Thread.Sleep(10);
            foreach(var device in discoveredDevices)
            {
                if (device.Name.Contains(name))
                {
                    await adapter.ConnectToDeviceAsync(device);
                    WriteAdvertisementRecords(device);
                }
            }
        }

        internal Task Disconnect(IDevice dev)
        {
            return adapter.DisconnectDeviceAsync(dev);
        }
    }
}
