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
        // DataBase dbUsers = new DataBase();
        List<User> usuarios = new List<User>();
        
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
            return View();
        }

        public IActionResult Sing()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sing(User user)
        {
            if(ModelState.IsValid)
            {
                // dbUsers.usuarios.Add(user);
                // dbUsers.SaveChanges();
                // ModelState.Clear();
                usuarios.Add(user);
                ViewBag.Message = user.FirstName+" registrado(a) com sucesso.";
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            // var account = dbUsers.usuarios.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            
            User account = new User();
            account.UserID= user.UserID;
            account.Username = user.Username;
            account.Password = user.Password;

            // foreach(User item in usuarios){
            //     if(item.Username == user.Username && item.Password == user.Password){
            //         account = item;
            //     }
            // }            
            
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
            return RedirectToAction("Login");
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