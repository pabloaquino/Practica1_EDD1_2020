using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LABORATORIO_0_.Models
{
    public class ClientesController : Controller
    {
        public class Cliente
        {
            public string nombre { get; set; }
            public string apellido { get; set; }
            public int telefono { get; set; }
            public string descripcion { get; set; }
        }
        public List<Cliente> cliente = new List<Cliente>();
        public IActionResult Index()
        {
            return View();
        }
    }

}