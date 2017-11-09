using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie.Models;
using System.Text;

using Newtonsoft.Json;  
using System.Net.Http;  
using System.Net.Http.Headers;  


namespace movie.Controllers
{
    public class FilmesController : Controller
    {   
        public async Task<ActionResult> Listar()
        {
            Service s = new Service();

            List<Filmes> filmes = await s.GetMovies();
            return View(filmes);
        }

        public IActionResult Detalhes(int Id)
        {
            /*
            Filmes FilmeEspecifico = null;
            Service s = new Service();
            List<Filmes> filmes = s.GetFilmes();
            
            foreach(Filmes item in filmes)
            {
                if(item.Id == Id)
                {
                    FilmeEspecifico = item;
                }
            }*/
            return View();
        }

        public async Task<IActionResult> Adicionar(string movieName, string movieYear)
        {
            Service s = new Service();
            Filmes heat = await s.GetMoviesOmdb("Interstellar", "2014");
            s.PostMovie(heat);

            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }

        public IActionResult Ranking()
        {
            /*
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
            */
            return View();
        }
        
        public IActionResult Ranking250()
        {
            // Service s = new Service();
            // List<Filmes> filmes = s.GetMovies();
            return View();
        }

        public IActionResult AtorDetalhes(int Id)
        {
            // Service s = new Service();
            // Ator ator = s.GetAtor(Id);
            return View();
        }

        public IActionResult Cast()
        {
            // Service s = new Service();
            // List<Ator> atores = s.GetAtores();
            return View();
        }
    }
}
