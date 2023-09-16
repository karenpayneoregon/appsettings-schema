namespace CreateClassesForAppsettingsApp.Models;

public class ConnectionsConfiguration
{
    public string ActiveEnvironment { get; set; }
    public string Development { get; set; }
    public string Stage { get; set; }
    public string Production { get; set; }
}