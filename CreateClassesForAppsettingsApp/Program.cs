using CreateClassesForAppsettingsApp.Classes;

namespace CreateClassesForAppsettingsApp;

internal class Program
{
    static void Main(string[] args)
    {
        Operations.CreateNew();
        Operations.ReadFile();

        Console.ReadLine();
    }
}