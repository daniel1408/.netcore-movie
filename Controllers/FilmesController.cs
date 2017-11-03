using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie.Models;
using System.Text;

namespace movie.Controllers
{
    public class FilmesController : Controller
    {
        public IActionResult Listar()
        {
            Service s = new Service();
            Filmes[] filmes = s.GetFilmes();
            return View(filmes);
        }

        public IActionResult Detalhes(int Id)
        {
            Filmes FilmeEspecifico = null;
            Service s = new Service();
            Filmes[] filmes = s.GetFilmes();
            
            for(int i = 0; i<filmes.Length; i++)
            {
                if(filmes[i].Id == Id)
                {
                    FilmeEspecifico = filmes[i];
                }
            }
            return View(FilmeEspecifico);
        }

        public IActionResult Adicionar()
        {
            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }

        public IActionResult Ranking()
        {
            List<Filmes> FilmesTopTen = new List<Filmes>();

            Service s = new Service();
            Filmes[] filmes = s.GetFilmes();
            
            for(int i = 0; i<filmes.Length; i++)
            {
                if(filmes[i].IsTopTen == 1)
                {
                    FilmesTopTen.Add(filmes[i]);
                }
            }
            
            return View(FilmesTopTen);
        }
        
        public IActionResult Ranking250()
        {
            Service s = new Service();
            Filmes[] filmes = s.GetFilmes();
            return View(filmes);
        }
    }
}
