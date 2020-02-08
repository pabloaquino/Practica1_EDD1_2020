using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab0.Models;

namespace Lab0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<Cliente> listaClientes = new List<Cliente>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CrearClientes()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearClientes(string nombre, string apellido, int telefono, string descripion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Cliente cliente = new Cliente();
                    cliente.nombre = nombre;
                    cliente.apellido = apellido;
                    cliente.telefono = telefono;
                    cliente.descripcion = descripion;
                    //codigo aqui
                    listaClientes.Add(cliente);
                    return RedirectToAction("Mostrar");
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception)
            {

                return View();
            }
        }
        [HttpGet]
        public IActionResult Mostrar()
        {

            return View(listaClientes);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
