using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelcomeToWeb.Models;

namespace WelcomeToWeb.Controllers
{
    public class APIController : Controller
    {
        [Route("/API")]
        public IActionResult API()
        {
            
            var man = new ChoiceModel
            {
                Name = "Jeremiah",
                Height = "6 feet 8 inches",
                EyeColor = "Blue"
            };
            return Json(man);
        }

        
    }
}
