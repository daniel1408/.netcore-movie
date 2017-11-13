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

        public async Task<IActionResult> Detalhes(int Id)
        {
            Service s = new Service();
            Filmes EspecificMovie = null;

            List<Filmes> filmes = await s.GetMovies();
            foreach(Filmes item in filmes){
                if(item.Id == Id){
                    EspecificMovie = item;
                }
            }

            return PartialView(EspecificMovie);
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Adicionar([FromForm] string movieName, string movieYear)
        {
            Service s = new Service();
            Filmes filme = await s.GetMoviesOmdb(movieName, movieYear);

            if(filme.Title == null){
                return RedirectToAction("Confirmation");
            }else{
                s.PostMovie(filme);
                return RedirectToAction("Listar");
            }
        }

        public IActionResult Confirmation()
        {
            return PartialView();
        }

        public IActionResult Deletar(int id)
        {
            Service s = new Service();
            Filmes filme = s.DeleteMovie(id);
            return View(filme);
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
