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
    public string FirstName { get; set; }

    public void OnGet()
    {
        _logger.LogInformation("inside OnGet(): FirstName = {FirstName}", FirstName);
        if (string.IsNullOrWhiteSpace(FirstName))
        {
            FirstName = "User";
        }
    }
}

