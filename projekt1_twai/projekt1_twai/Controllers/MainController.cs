using projekt1_twai.DAL;
using projekt1_twai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace projekt1_twai.Controllers
{
    public class MainController : Controller
    {

        UserClass us = new UserClass();
        CarClass cc = new CarClass();
        // GET: Main
        public ActionResult Index()
        {
            ViewBag.lista = cc.GetList();
            if (Request.IsAuthenticated)
            {          
                return View("MainPage");
            }
            return View();
        }

        public ActionResult Logowanie()
        {
            if(Request.IsAuthenticated)
            {
                return View("MainPage");
            }
            return View("Login");
        }
        public ActionResult Authorize()
        {
            if (us.Logging(Request.Form["login"], Request.Form["password"]))
            {
                FormsAuthentication.SetAuthCookie(Request.Form["login"], true);
                Session["user"] = Request.Form["login"];
                return Redirect("~/Main/MainPage");
            }
            else
            {
                ModelState.AddModelError("", "Blad logowania");
                return Redirect("~/Main/Login");
            }
        }
        [Authorize]
        public ActionResult MainPage()
        { 
            ViewBag.lista = cc.GetList();
            return View();
        }

        [Authorize]
        public ActionResult AddAdmin()
        {            
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult AddA()
        {
            if (us.AddUser(Request.Form["login"], Request.Form["password"]))
            {
                ModelState.AddModelError("", "Dodano pomyślnie");
                return Redirect("~/Main/AddAdmin");
            }
            ModelState.AddModelError("", "Wybierz inną nazwę użytkownika!");

            return Redirect("~/Main/AddAdmin");
        }

        [Authorize]
        public ActionResult Wyloguj()
        {
            FormsAuthentication.SignOut();
            ModelState.AddModelError("", "Wylogowano");
            return Redirect("~/Main/Index");
        }

        ///////////////////
        [Authorize]
        public ActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Show(int id)
        {
            return View("Index");

        }
               
        [Authorize]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Car c = cc.GetItem(id);
            if (c != null)
            {
                Session["editID"] = id;
                return View(c);
            }
            else
            {
                ModelState.AddModelError("", "Brak wpisu o danym id!");
                return Redirect("~/Main/MainPage");
            }
            
        }
        [Authorize]
        [HttpPost]
        public ActionResult Edit(Car u)
        {
            if (ModelState.IsValid)
            {
                u.ID = (int)Session["editID"];
                cc.Update(u);
                return Redirect("~/Main/MainPage");
            }
            else
            {
                return View(u);
            }
        }
        [Authorize]
        [HttpPost]
        public ActionResult Add(Car u)
        {
            if (ModelState.IsValid)
            {
                cc.Add(u);
                return Redirect("~/Main/MainPage");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            if(cc.Del(id))
            {
                return Redirect("~/Main/MainPage");
            }
            ModelState.AddModelError("", "Nie usunięto!");
            return Redirect("/");
                
        }
        
    }
}