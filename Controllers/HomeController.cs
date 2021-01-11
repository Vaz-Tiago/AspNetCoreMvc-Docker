using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Models;
using mvc1.Models;

namespace mvc1.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        private string message;
        public HomeController(IRepository repo, IConfiguration config)
        {
            repository = repo;
            // HOSTNAME é uma variavel de ambiente do DOCKER
            message = !string.IsNullOrEmpty(config["HOSTNAME"]) ? $"CONTAINER ID: {config["HOSTNAME"]}" : "ASP NET CORE MVC - DOCKER";
        }
        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(repository.Produtos);
        }
    }
}
