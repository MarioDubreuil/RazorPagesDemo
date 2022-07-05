using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesUI.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty(SupportsGet = true)]
    public string City
    { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("inside OnGet(): FirstName = {FirstName}", City);
        if (string.IsNullOrWhiteSpace(City))
        {
            City = "The web";
        }
    }
}

