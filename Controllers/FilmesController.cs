using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie.Models;

namespace movie.Controllers
{
    public class FilmesController : Controller
    {
        public IActionResult Filmes()
        {
            return View();
        }
    }
}
