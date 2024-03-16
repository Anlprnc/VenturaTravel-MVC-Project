using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace VenturaCore.Views.Shared
{
    public class _UILayout : PageModel
    {
        private readonly ILogger<_UILayout> _logger;

        public _UILayout(ILogger<_UILayout> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}