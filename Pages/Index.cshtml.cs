using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShowEnvs.Pages;

[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _config;
    public string? EnvironmentName { get; set; } = null!;
    public string? Secret { get; set; }
    public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }
    
    public void OnGet()
    {
        this.EnvironmentName = _config["ASPNETCORE_ENVIRONMENT"];
        this.Secret = _config["Secret"];
    }
}
