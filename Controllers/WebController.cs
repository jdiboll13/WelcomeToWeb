using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelcomeToWeb.Models;

namespace WelcomeToWeb.Controllers
{
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
