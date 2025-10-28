using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

[Authorize]
public class DashboardModel : PageModel
{
    public string UserName { get; private set; }

    public void OnGet()
    {
        UserName = User.Identity.Name;
    }
}
