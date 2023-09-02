using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace STAMP2023.Pages
{
    public class About2022Model : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public About2022Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}