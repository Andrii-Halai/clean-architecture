using CleanArchitecture.Controllers.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CleanArchitecture.Controllers.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ConfigurationController : ControllerBase
{
    private readonly ILogger<ConfigurationController> _logger;
    private readonly DemoSettings _demoSettings;
    private readonly IConfiguration _configuration;

    public ConfigurationController(
        ILogger<ConfigurationController> logger,
        IOptions<DemoSettings> demoSettingsOptions,
        IConfiguration configuration)
    {
        _logger = logger;
        _demoSettings = demoSettingsOptions.Value;
        _configuration = configuration;
    }
    
    [HttpGet]
    public ActionResult<ConfigurationResponse> GetConfiguration()
    {
        
        var demoEnvVarDirect = Environment.GetEnvironmentVariable("DEMO_ENV_VAR") ?? "Not set (direct)";
        
        // Log values for debugging
        _logger.LogInformation("=== Configuration Demo ===");
        _logger.LogInformation("AppName: {AppName}", _demoSettings.AppName);
        _logger.LogInformation("LogLevel: {LogLevel}", _demoSettings.LogLevel);
        _logger.LogInformation("FeatureEnabled: {FeatureEnabled}", _demoSettings.FeatureEnabled);
        _logger.LogInformation("DEMO_ENV_VAR (direct): {DemoEnvVarDirect}", demoEnvVarDirect);
        _logger.LogInformation("Environment: {Environment}", Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Not set");
        _logger.LogInformation("==========================");

        var response = new ConfigurationResponse
        {
            AppName = _configuration["DemoSettings:AppName"] ?? "",
            LogLevel = _demoSettings.LogLevel,
            FeatureEnabled = _demoSettings.FeatureEnabled,

            
            CurrentEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Not set",
        };

        return Ok(response);
    }
}

public class ConfigurationResponse
{
    public string AppName { get; set; } = string.Empty;
    
    public string LogLevel { get; set; } = string.Empty;
    
    public bool FeatureEnabled { get; set; }
    
    public string DemoEnvVar { get; set; } = string.Empty;


    public string CurrentEnvironment { get; set; } = string.Empty;
    
    public ConfigurationNotes ConfigurationNotes { get; set; } = new();
}

public class ConfigurationNotes
{

    public string Priority { get; set; } = string.Empty;
    
    public string EnvironmentVariableFormat { get; set; } = string.Empty;

    public string[] TestCommands { get; set; } = Array.Empty<string>();
}


// appsetting.json -> appsettings.Development.json -> secrets.json -> Environment Variables -> Command Line Args
