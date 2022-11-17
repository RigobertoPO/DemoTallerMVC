using DemoTallerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoTallerMVC.Controllers
{
    public class ProductosController : Controller
    {
        private DemoModelo db = new DemoModelo();
        // GET: Productos
        public ActionResult Index()
        {
            using(var conexion= new DemoModelo())
            {
                ViewData["productos"] =(from p in conexion.Productos select p).ToList();
                return View();
            }
            
        }
        // GET: Clientes/Create
        public ActionResult Nuevo()
        {
            return View();
        }
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                producto.Id = Guid.NewGuid();
                db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(producto);
        }
    }
}