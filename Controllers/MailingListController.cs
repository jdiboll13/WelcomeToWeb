using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WelcomeToWeb.Models;

namespace WelcomeToWeb.Controllers
{
    public class MailingListController : Controller
    {
        public IActionResult Index()
        {
            var emailList = new List<string>();
            using (var reader = new StreamReader(System.IO.File.Open("emails.csv", FileMode.Open)))
            {
                while (reader.Peek() >= 0)
                {
                    var emailFromFile = reader.ReadLine();
                    var data = emailFromFile.Split(',');
                    foreach (var item in data)
                    {
                        emailList.Add(item);

                    }
                }
            }
            return View(emailList);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
