namespace CleanArchitecture.Controllers.Configuration;

public class DemoSettings
{

    public string AppName { get; } = string.Empty;
    
    public string LogLevel { get; } = string.Empty;
    
    public bool FeatureEnabled { get; set; }
}
