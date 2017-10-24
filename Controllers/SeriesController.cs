using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using texas_movie.Models;

namespace texas_movie.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }
    }
}
