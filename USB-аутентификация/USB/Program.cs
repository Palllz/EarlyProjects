
using System.Collections.Generic;
using System.Management;

class Program
{
    static void Main(string[] args)
    {
        string targetDeviceID = "USB\\VID_8564&PID_1000\\BCZ02IB0";

        var usbDevices = GetUSBDevices();

        foreach (var usbDevice in usbDevices)
        {
            Console.WriteLine($"Device ID: {usbDevice.DeviceID},  Description: {usbDevice.Description}");

            if (usbDevice.DeviceID == targetDeviceID)
            {
                Console.WriteLine("Токен найден. Успешная активация!");
                return;
            }
        }
        Console.WriteLine("Токен не найден. Ошибка активации!");
    }

    static List<(string DeviceID, string Description)> GetUSBDevices()
    {
        List<(string DeviceID, string Description)> devices = new List<(string, string)>();

        using var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub");
        using ManagementObjectCollection collection = searcher.Get();

        foreach (var device in collection)
        {
            string deviceID = (string)device.GetPropertyValue("DeviceID");
            string description = (string)device.GetPropertyValue("Description");

            devices.Add((deviceID, description));
        }

        return devices;
    }
}

