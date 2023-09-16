using System.Text.Json;
using CreateClassesForAppsettingsApp.Models;

namespace CreateClassesForAppsettingsApp.Classes;

internal class Operations
{
    public static string SettingsFileName = "appsettings.json";

    public static void CreateNew()
    {
        ConfigurationRoot root = new()
        {
            ConnectionsConfiguration = new()
            {
                ActiveEnvironment = Environments.Development.ToString(),
                Development = "TODO Dev",
                Stage = "TODO Stage",
                Production = "TODO Prod"
            }
        };

        File.WriteAllText(SettingsFileName, JsonSerializer.Serialize(
            root, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static void ReadFile()
    {
        var root = JsonSerializer.Deserialize<ConfigurationRoot>(File.ReadAllText(SettingsFileName));
        Console.WriteLine(root.ConnectionsConfiguration.ActiveEnvironment);
        Console.WriteLine(root.ConnectionsConfiguration.Development);
        Console.WriteLine(root.ConnectionsConfiguration.Stage);
        Console.WriteLine(root.ConnectionsConfiguration.Production);
    }
}