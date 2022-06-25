using frontend;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace frontend.Pages;

public class IndexModel : PageModel
{
    public IEnumerable<Statistics>? Statistics { get; set; }

    private readonly StatisticsClient _client;

    public IndexModel(StatisticsClient client)
    {
        _client = client;
    }

    public async Task OnGetAsync()
    {
        Statistics = await _client.Get();
    }
}
