using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RNPN.Dominio;
using RNPN.Models;
using RNPN.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RNPN.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;
        private IPersona _persona;

        public PersonaController(ILogger<PersonaController> logger, IPersona _persona)
        {
            this._persona = _persona;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //for (var i = 0; i <= 100; i++)
            //{
            //    Persona persona = new Persona();
            //    persona.NombrePersona = "Manuel";
            //    persona.EdadPersona = 21;
            //    persona.DescripcionPersona = "La puerta negra esta cerrada con 3 candados";
            //    _persona.Guardar(persona);
            //}
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Persona personaModel)
        {
            if (ModelState.IsValid)
            {
                Persona persona = new Persona();
                persona.NombrePersona = personaModel.NombrePersona;
                persona.EdadPersona = personaModel.EdadPersona;
                persona.DescripcionPersona = personaModel.DescripcionPersona;

                _persona.Guardar(persona);
                return Redirect("/Persona/ListaPersonas");
            }

            else
            {
                return View("Index", personaModel);
            }
        
        }

        public IActionResult ListaPersonas()
        {
            return View();
        }

        public IActionResult ListarJson()
        {
            var listaPersonasJson = _persona.ListaPersonas();
            //creando json con la lista anterior
            return Json(new { data = listaPersonasJson });
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
