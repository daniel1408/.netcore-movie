using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using texas_movie.Models;

namespace texas_movie.Controllers
{
    public class CastController : Controller
    {
        public IActionResult Cast()
        {
            return View();
        }
    }
}
