using System;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ProductController: Controller
    {
        private ProductData _product = new ProductData();

        //1° Listar Producto
        public ActionResult Index()
        {
            return View(_product.GetList());
        }

        //2° Crear Producto
        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        //3° Editar Producto
        public ActionResult Edit(int Id)
        {
            var product = _product.GetProduct(Id);
            if (product == null)
                RedirectToAction("Index");
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.Update(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        //4° Eliminar Producto
        public ActionResult Delete(int Id)
        {
            var product = _product.GetProduct(Id);
            if (product == null)
            {
                RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            _product.Delete(product);
            return RedirectToAction("Index");
        }

    }
}
