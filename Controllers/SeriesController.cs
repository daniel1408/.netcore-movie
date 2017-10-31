﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie.Models;

namespace movie.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Listar()
        {
            Series[] Series = new Series[] 
            {
                new Series
                    {
                        Id = 1,
                        Nome = "The Americans",
                        Categoria = "Suspense",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 2,
                        Nome = "The Big Bang Theory",
                        Categoria = "Comédia",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 3,
                        Nome = "The Black List",
                        Categoria = "Ação",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 4,
                        Nome = "Chuck",
                        Categoria = "Espionagem",
                        Nota = 7
                    },
                new Series
                    {
                        Id = 5,
                        Nome = "Lethal Weapon",
                        Categoria = "Ação",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 6,
                        Nome = "How i Meet Your Mother",
                        Categoria = "Comédia",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 7,
                        Nome = "Quantic",
                        Categoria = "Suspense",
                        Nota = 7
                    },
                    new Series
                    {
                        Id = 1,
                        Nome = "The Americans",
                        Categoria = "Suspense",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 2,
                        Nome = "The Big Bang Theory",
                        Categoria = "Comédia",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 3,
                        Nome = "The Black List",
                        Categoria = "Ação",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 4,
                        Nome = "Chuck",
                        Categoria = "Espionagem",
                        Nota = 7
                    },
                new Series
                    {
                        Id = 5,
                        Nome = "Lethal Weapon",
                        Categoria = "Ação",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 6,
                        Nome = "How i Meet Your Mother",
                        Categoria = "Comédia",
                        Nota = 8
                    },
                new Series
                    {
                        Id = 7,
                        Nome = "Quantic",
                        Categoria = "Suspense",
                        Nota = 7
                    },

            };

            return View(Series);
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