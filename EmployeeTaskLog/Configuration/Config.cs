using System.Text.Json;

namespace EmployeeTaskLog.Configuration;

internal class Config
{
    public string connstr { get; set; } = null!;

    public static string ConnectionString()
    {
        string jsonString = File.ReadAllText("./configSecret.json");
        Config cfg = JsonSerializer.Deserialize<Config>(jsonString)!;
        return cfg.connstr;
    }
    
}
