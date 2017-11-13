using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie.Models;

namespace movie.Controllers
{   
    public class SystemController : Controller
    {
        public IActionResult Login()
        {
            return PartialView();
        }

        public IActionResult Sing()
        {
            return PartialView();
        }
    }
}
