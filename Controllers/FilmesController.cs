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
            List<Filmes> filmes = s.GetFilmes();
            return View(filmes);
        }

        public IActionResult Detalhes(int Id)
        {
            Filmes FilmeEspecifico = null;
            Service s = new Service();
            List<Filmes> filmes = s.GetFilmes();
            
            foreach(Filmes item in filmes)
            {
                if(item.Id == Id)
                {
                    FilmeEspecifico = item;
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
            List<Filmes> filmes = s.GetFilmes();
            
            foreach(Filmes item in filmes)
            {
                if(item.IsTopTen == 1)
                {
                    FilmesTopTen.Add(item);
                }
            }
            
            return View(FilmesTopTen);
        }
        
        public IActionResult Ranking250()
        {
            Service s = new Service();
            List<Filmes> filmes = s.GetFilmes();
            return View(filmes);
        }

        public IActionResult AtorDetalhes(int Id)
        {
            Service s = new Service();
            Ator ator = s.GetAtor(Id);
            return View(ator);
        }

        public IActionResult Cast()
        {
            Service s = new Service();
            List<Ator> atores = s.GetAtores();
            return View(atores);
        }
    }
}
