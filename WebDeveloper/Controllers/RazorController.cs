using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class RazorController : Controller
    {
        // GET: Razor
        public ActionResult Index()
        {
            var listclients = new List<Client>
            {
                new Client {ID=1, Name="Jose", LastName = "Perez"},
                new Client {ID=2,Name="Juan", LastName = "Perez"},
                new Client {ID=3,Name="Juanelo", LastName = "Perez"},
                new Client {ID=4,Name="Alan", LastName = "Perez"},
                new Client {ID=5,Name="Pedro", LastName = "Perez"}
            };

            return View(listclients);
        }

        public ActionResult Product()
        {
            var productData = new ProductData();
            return View(productData.GetFakeProducts());
        }
    }
}