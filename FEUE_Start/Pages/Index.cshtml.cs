using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public string UserName { get; private set; }

    public void OnGet()
    {
        UserName = User.Identity?.Name ?? "Guest";
    }
}
