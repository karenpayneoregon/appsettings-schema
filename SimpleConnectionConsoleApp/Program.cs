using Microsoft.Data.SqlClient;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace SimpleConnectionConsoleApp
{
    partial class Program
    {
        static async Task Main(string[] args)
        {
            await using var cn = new SqlConnection(ConnectionString());
            await cn.OpenAsync();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

