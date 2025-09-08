namespace exercise.wwwapi.Configuration;

public interface IConfigurationSettings
{
    string? GetValue(string key);
}