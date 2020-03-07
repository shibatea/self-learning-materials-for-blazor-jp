﻿using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorWOL.Shared;

namespace BlazorWOL.Client
{
    public class DeviceService
    {
        private List<Device> Devices { get; } = new List<Device>
        {
            new Device {Name = "Odin", MACAddress = "00:15:5D:52:CA:B6"},
            new Device {Name = "Thor", MACAddress = "00:0C:29:30:7D:5D"},
            new Device {Name = "Fenrir", MACAddress = "00:50:56:01:43:86"}
        };

        public async Task<List<Device>> GetDevicesAsync()
        {
            return await Task.FromResult(Devices);
        }

        public async Task AddDeviceAsync(Device device)
        {
            await Task.Run(() => Devices.Add(device));
        }
    }
}