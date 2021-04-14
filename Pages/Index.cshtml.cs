﻿using WebApplication17.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication17.Models;

namespace WebApplication17.Pages
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
           
        }
    }
}
