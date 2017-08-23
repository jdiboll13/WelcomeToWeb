using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelcomeToWeb.Models;

namespace WelcomeToWeb.Controllers
{
    public class UserController : Controller
    {
        [Route("/User/{id}")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
