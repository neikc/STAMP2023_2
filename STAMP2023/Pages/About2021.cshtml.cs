using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace STAMP2023.Pages
{
    public class About2021Model : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public About2021Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}