using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Dynasty
{
    /// <summary>
    /// Represents a base class for electronic devices.
    /// </summary>
    internal abstract class ElectronicDevices
    {
        /// <summary>
        /// Gets or sets the brand of the device.
        /// </summary>
        public string deviceBrand { get; protected set; }

        /// <summary>
        /// Gets or sets the manufacturer of the device.
        /// </summary>
        public string deviceManufacturer { get; protected set; }

        /// <summary>
        /// Gets or sets the model of the device.
        /// </summary>
        public string deviceModel { get; protected set; }

        /// <summary>
        /// Gets or sets the type of the device.
        /// </summary>
        public string deviceType { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicDevices"/> class.
        /// </summary>
        /// <param name="deviceBrand">The brand of the device.</param>
        /// <param name="deviceManufacturer">The manufacturer of the device.</param>
        /// <param name="deviceModel">The model of the device.</param>
        /// <param name="deviceType">The type of the device.</param>
        public ElectronicDevices(string deviceBrand, string deviceManufacturer, string deviceModel, string deviceType)
        {
            this.deviceBrand = deviceBrand;                 // The use of "this.variable" is to differentiate between the class variable and the constructor parameter.
            this.deviceManufacturer = deviceManufacturer;   // In previous tasks you may have used code sections like the one below:
            this.deviceModel = deviceModel;                 //
            this.deviceType = deviceType;                   //
        }

        /// <summary>
        /// Gets the details of the device.
        /// </summary>
        /// <returns>A string containing the details of the device.</returns>
        public string getDeviceDetails()
        {                                                           // Using \n to create a new line in the string.
            return "Brand: " + deviceBrand + "\n" +                   // This returns the details of the device brand in a string format.
                   "Manufacturer: " + deviceManufacturer + "\n" +     // This returns the details of the device manufacturer in a string format.
                   "Model: " + deviceModel + "\n" +                   // This returns the details of the device model in a string format.
                   "Type: " + deviceType;                             // This returns the details of the device type in a string format.
        }
    }

    /// <summary>
    /// Represents a class for Laptop Devices, inheriting from ElectronicDevices.
    /// </summary>
    internal class LaptopDevices : ElectronicDevices
    {
        /// <summary>
        /// Gets or sets the operating system of the laptop.
        /// </summary>
        private string laptopOS { get; set; }

        /// <summary>
        /// Gets or sets the version of the laptop's operating system.
        /// </summary>
        private string laptopProcessor { get; set; }

        /// <summary>
        /// Gets or sets the screen size of the laptop.
        /// </summary>
        private double laptopScreenSize { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LaptopDevices"/> class.
        /// </summary>
        /// <param name="deviceBrand">The brand of the device.</param>
        /// <param name="deviceManufacturer">The manufacturer of the device.</param>
        /// <param name="deviceModel">The model of the device.</param>
        /// <param name="deviceType">The type of the device.</param>
        /// <param name="laptopOS">The operating system of the laptop.</param>
        /// <param name="laptopProcessor">The version of the laptop's operating system.</param>
        /// <param name="LaptopScreenSize">The screen size of the laptop.</param>
        public LaptopDevices(string deviceBrand, string deviceManufacturer, string deviceModel, string deviceType, string laptopOS, string laptopProcessor, double LaptopScreenSize)
            : base(deviceBrand, deviceManufacturer, deviceModel, deviceType)
        {
            this.laptopOS = laptopOS;
            this.laptopProcessor = laptopProcessor;
            this.laptopScreenSize = LaptopScreenSize;
        }

        /// <summary>
        /// Gets the details of the laptop, including its operating system and version.
        /// </summary>
        /// <returns>A string containing the laptop's details.</returns>
        public string getLaptopDetails()
        {
            return "Laptop OS: " + laptopOS + "\n" +
                   "Laptop Version: " + laptopProcessor + "\n" +
                   "Screen Size: " + laptopScreenSize + "\n";
        }
    }


    /// <summary>
    /// Represents a class for Mobile Devices, inheriting from ElectronicDevices.
    /// </summary>
    internal class MobileDevices : ElectronicDevices
    {
        /// <summary>
        /// Gets or sets the operating system of the mobile device.
        /// </summary>
        private string mobileOS { get; set; }

        /// <summary>
        /// Gets or sets the version of the mobile device's operating system.
        /// </summary>
        private string mobileVersion { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileDevices"/> class.
        /// </summary>
        /// <param name="deviceBrand">The brand of the device.</param>
        /// <param name="deviceManufacturer">The manufacturer of the device.</param>
        /// <param name="deviceModel">The model of the device.</param>
        /// <param name="deviceType">The type of the device.</param>
        /// <param name="mobileOS">The operating system of the mobile device.</param>
        /// <param name="mobileVersion">The version of the mobile device's operating system.</param>
        public MobileDevices(string deviceBrand, string deviceManufacturer, string deviceModel, string deviceType, string mobileOS, string mobileVersion)
            : base(deviceBrand, deviceManufacturer, deviceModel, deviceType)
        {
            this.mobileOS = mobileOS;
            this.mobileVersion = mobileVersion;
        }

        /// <summary>
        /// Gets the details of the mobile device, including its operating system and version.
        /// </summary>
        /// <returns>A string containing the mobile device's details.</returns>
        public string getMobileDetails()
        {
            return "Mobile OS: " + mobileOS + "\n" +
                   "Mobile Version: " + mobileVersion;
        }
    }
}
