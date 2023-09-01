using Dependency_Injection_Service_Lifetimes.Models;
using Dependency_Injection_Service_Lifetimes.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace Dependency_Injection_Service_Lifetimes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly IScopedService _scoped1;
        private readonly IScopedService _scoped2;

        private readonly ISingeltonService _singelton1;
        private readonly ISingeltonService _singelton2;

        private readonly  ITransientService _transient1;
        private readonly ITransientService _transient2;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
            
        //}

        public HomeController(ITransientService transientService1, ITransientService transientService2, ISingeltonService singeltonService1, ISingeltonService singeltonService2, IScopedService? scopedService1, IScopedService scopedService2)
        {
            _scoped1 = scopedService1;
            _scoped2 = scopedService2;

            _transient1 = transientService1;
            _transient2 = transientService2;

            _singelton1 = singeltonService1;
            _singelton2 = singeltonService2;
        }

        public IActionResult Index( )
        {
           StringBuilder messages = new StringBuilder();
            messages.Append($"Transient 1 : {_transient1.GetGuid()}\n");
            messages.Append($"Transient 2 : {_transient2.GetGuid()}\n\n\n");

            messages.Append($"Scoped 1 : {_scoped1.GetGuid()}\n");
            messages.Append($"Scoped 2 : {_scoped2.GetGuid()}\n\n\n");

            messages.Append($"Singelton 1 : {_singelton1.GetGuid()}\n");
            messages.Append($"Singelton 2 : {_singelton2.GetGuid()}\n\n\n");

            return Ok(messages.ToString());
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