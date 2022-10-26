using System.Text.Json;

namespace EmployeeTaskLog.Configuration;

public class Config
{
    public string connstr { get; set; } = null!;

    private static Lazy<Config> config = new Lazy<Config>(Create);
    //public static Config Instance { get => config.Value; }

    private static Config Create()
    {
        string jsonString = File.ReadAllText("./configSecret.json");
        Config cfg = JsonSerializer.Deserialize<Config>(jsonString)!;
        return cfg;
    }

    
    public static string ConnectionString()
    {
        //return Instance.connstr
        return config.Value.connstr;
    }
}
