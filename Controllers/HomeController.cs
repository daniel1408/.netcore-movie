using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie.Models;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace movie.Controllers
{
    public class HomeController : Controller
    {
        DataBase dbUsers = new DataBase();
        
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return View();
            }
            else
            {
                return View();
            }
        }

        public IActionResult Login()
        {
            return PartialView();
        }

        public IActionResult Sing()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Sing(User user)
        {
            if(ModelState.IsValid)
            {
                dbUsers.usuarios.Add(user);
                dbUsers.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = user.FirstName+" registrado(a) com sucesso.";
            }

            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var account = dbUsers.usuarios.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("UserID", account.UserID.ToString());
                HttpContext.Session.SetString("Username", account.Username);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Nome ou senha de usuário estão errados.");
            }
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Sobre o site";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contatos";
            return View();
        }
    }
}