namespace exercise.wwwapi.Configuration;

public class ConfigurationSettings : IConfigurationSettings
{
    private readonly IConfiguration _configuration;

    public ConfigurationSettings()
    {
        _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddUserSecrets<Program>().Build();
    }

    public string GetValue(string key)
    {
        return _configuration.GetValue<string>(key)!;
    }
}