using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class ClientController : Controller
    {
        private ClientData _client = new ClientData();

        // GET: Client
        public ActionResult Index()
        {
            var client = new ClientData();
            return View(_client.GetList());
        }

        //1° Crear Cliente
        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        //2° Eliminar Cliente
        public ActionResult Delete(int id)
        {
            //Primera línea de código
            //return View(_client.GetList().Where(c => c.ID == id).FirstOrDefault());
            
            //Segunda línea de código
            //return View(_client.GetClientById(id));

            //Código del profe
            var client = _client.GetClient(id);
            if (client== null)
                RedirectToAction("Index");
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            _client.Delete(client);
            return RedirectToAction("Index");

            //Comentario
            //if (ModelState.IsValid)
            //[No se requiere esta línea de código, ya que no validamos nada]
        }


        //3° Editar Cliente
        public ActionResult Edit(int id)
        {
            //Primera línea de código
            //return View(_client.GetList().Where(c => c.ID == id).FirstOrDefault());

            //Segunda línea de código
            //return View(_client.GetClientById(id));

            //Código del profe
            var client = _client.GetClient(id);
            if (client == null)
                RedirectToAction("Index");
            return View(client);
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}