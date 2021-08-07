using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Serilog;

namespace SerilogDemo.WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Hello World");
            try
            {
                _logger.LogInformation("Hello Again");
                throw new Exception("Tis but a mere fail");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception lols");
            }
        }
    }
}
