using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;
using Portafolio.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ServicioDelimitado servicioDelimitado;
        private readonly ServicioTransitorio servicioTransitorio;
        private readonly ServicioUnico servicioUnico;
        private readonly IRepositorioProyecto respProyecto;

        public HomeController(ILogger<HomeController> logger,
            ServicioDelimitado servicioDelimitado, 
            ServicioTransitorio servicioTransitorio, 
            ServicioUnico servicioUnico,
            IRepositorioProyecto respProyecto)
        {
            _logger = logger;
            this.servicioDelimitado = servicioDelimitado;
            this.servicioTransitorio = servicioTransitorio;
            this.servicioUnico = servicioUnico;
            this.respProyecto = respProyecto;
        }

        public IActionResult Index()
        {
            var guidViewModel = new EjemploGUIDViewModel()
            {
                Delimitado = servicioDelimitado.obtenerGuid,
                Transitorio = servicioTransitorio.obtenerGuid,
                Unico = servicioUnico.obtenerGuid
            };

            var proyectos = respProyecto.obtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel()
            {
                proyectos = proyectos,
                ejemploGUID = guidViewModel
            };

            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            var proyectos = respProyecto.obtenerProyectos();
            return View(proyectos);
        }


        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Gracias(ContactoViewModel contacto)
        {
            var form = contacto;
            return View(form);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}