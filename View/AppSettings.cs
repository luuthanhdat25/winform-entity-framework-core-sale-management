using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace WinformLayer.View
{
    internal class AppSettings
    {
        public Dictionary<string, string>? AdminCredentials { get; set; }

        public static AppSettings LoadAppSettings()
        {
            string jsonFilePath = "D:\\Workspace\\C#\\Ef_core_learn\\SaleManagementWinform\\appsettings.json";

            try
            {
                if (!File.Exists(jsonFilePath))
                {
                    Console.WriteLine("File 'appsettings.json' not found.");
                    return null;
                }

                string jsonData = File.ReadAllText(jsonFilePath);

                // Deserialize JSON thành đối tượng AppSettings
                AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(jsonData);

                return appSettings;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading app settings: {ex.Message}");
                return null;
            }
        }
    }
}
