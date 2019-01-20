using Portfolio.Domain.Entities;
using Protfolio.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationCliente clienteLogado;
        public HomeController()
        {
            clienteLogado = ApplicationConstrutor.AplicacaoCliente();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Cliente cliente)
        {
            if (clienteLogado.LoginValido(cliente) == true)
            {
                return RedirectToRoute("Default", new { controller = "Cliente", action = "Index" });
            }
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}