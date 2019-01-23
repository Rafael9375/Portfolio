using Portfolio.Domain.Entities;
using Portfolio.MVC.Models;
using Protfolio.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.MVC.Controllers
{
    public class PedidoController : Controller
    {
        private RelatorioPedidos relatorio;
        private readonly ApplicationPedido appPed;
        public PedidoController()
        {
            appPed = ApplicationConstrutor.AplicacaoPedido();
            relatorio = new RelatorioPedidos();
        }
        // GET: Pedido
        public ActionResult Index()
        {
            List<RelatorioPedidos> _relatorio = new List<RelatorioPedidos>();
            _relatorio = relatorio.Conversao();
            return View(_relatorio);
        }

        // GET: Pedido/Details/5
        public ActionResult Details(int id)
        {
            return View(appPed.GetById(id));
        }

        // GET: Pedido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pedido/Create
        [HttpPost]
        public ActionResult Create(Pedido pedido)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appPed.Add(pedido);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pedido/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pedido/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
