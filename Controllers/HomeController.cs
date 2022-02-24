using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;
        private string message;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IRepository repository)
        {
            _repository = repository;
            
        }

        public IActionResult Index()
        {
            return View(_repository.Produtos);
        }
    }
}
