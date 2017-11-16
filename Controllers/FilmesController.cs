using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie.Models;
using movie.Service;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;


using Newtonsoft.Json;  
using System.Net.Http;  
using System.Net.Http.Headers;  


namespace movie.Controllers
{    
    public class FilmesController : Controller
    {   

        public async Task<ActionResult> Listar()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                WebService s = new WebService();
                List<Filmes> filmes = await s.GetMovies();

                filmes = filmes.OrderBy(o => o.Title).ToList();
                return View(filmes);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Detalhes(int Id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                WebService s = new WebService();
                Filmes EspecificMovie = null;

                List<Filmes> filmes = await s.GetMovies();
                foreach(Filmes item in filmes){
                    if(item.Id == Id){
                        EspecificMovie = item;
                    }
                }
                return PartialView(EspecificMovie);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Adicionar([FromForm] string movieName, string movieYear, string selectOK)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                WebService s = new WebService();
                Filmes filme = await s.GetMoviesOmdb(movieName, movieYear);

                if(filme.Title == null){
                    return RedirectToAction("Confirmation");
                }else{
                    filme.UserOption = selectOK;
                    s.PostMovie(filme);
                    return RedirectToAction("Listar");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Confirmation()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Deletar(int id)
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                WebService s = new WebService();
                Filmes filme = s.DeleteMovie(id);
                return PartialView(filme);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Ranking()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                WebService s = new WebService();
                List<Filmes> topDez = new List<Filmes>();
                List<Filmes> filmes = await s.GetMovies();

                foreach(Filmes item in filmes){
                    if(item.UserOption == "Top 10"){
                        topDez.Add(item);
                    }
                }
                
                topDez = topDez.OrderByDescending(o => o.imdbRating).ToList();
                return View(topDez);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        
        public async Task<ActionResult> Recomendations()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                WebService s = new WebService();
                List<Filmes> filmes = null;
                filmes = await s.Recomendation();
                
                return View(filmes);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<ActionResult> NaoVistos()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                WebService s = new WebService();
                List<Filmes> naoVistos = new List<Filmes>();
                List<Filmes> filmes = await s.GetMovies();

                foreach(Filmes item in filmes){
                    if(item.UserOption == "Não visto"){
                        naoVistos.Add(item);
                    }
                }
                
                naoVistos = naoVistos.OrderByDescending(o => o.imdbRating).ToList();
                return View(naoVistos);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<ActionResult> Vistos()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                WebService s = new WebService();
                List<Filmes> vistos = new List<Filmes>();
                List<Filmes> filmes = await s.GetMovies();

                foreach(Filmes item in filmes){
                    if(item.UserOption != "Não visto"){
                        vistos.Add(item);
                    }
                }
                
                vistos = vistos.OrderByDescending(o => o.imdbRating).ToList();
                return View(vistos);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

    }
}