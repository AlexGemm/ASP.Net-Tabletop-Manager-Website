using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebsite.Controllers
{
    public class EncountersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
