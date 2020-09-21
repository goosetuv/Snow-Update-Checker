namespace SUC.Classes
{
    public class DeviceModel
    {
        public string Name { get; set; } // Server Name
        public string Status { get; set; } // Server Status (Online, Offline)
        public string LMVersion { get; set; } // License Manager
        public string ISVersion { get; set; } // Inventory Server
        public bool LMUpdateAvailable { get; set; } // License Manager - Update Available or Not
        public bool ISUpdateAvailable { get; set; } // Inventory Server - Update Available or not
    }
}
