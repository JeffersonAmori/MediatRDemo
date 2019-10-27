using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatRDemo.Models;
using MediatR;
using MediatRDemo.Core.Commands;
using MediatRDemo.Core.Commands.Cliente.Queries;
using MediatRDemo.Core.Commands.Proposta.Queries;

namespace MediatRDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _medator;

        public HomeController(ILogger<HomeController> logger, IMediator medator)
        {
            _logger = logger;
            _medator = medator;
        }

        public IActionResult Index()
        {
            return View();
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
