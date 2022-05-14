using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RJSilvas.MyFinances.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RJSilvas.MyFinances.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TransactionController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NewTransaction()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pt-BR");

            return View(new Account());
        }

        [HttpPost]
        public IActionResult AddNewTransaction([FromForm] DateTime date, [FromForm] string category, [FromForm] decimal value)
        {
            Startup.Account.Transactions.Add(new Transaction() { Id = Startup.Account.Transactions.Count + 1, Category = category, Date = date, Value = value });

            return RedirectToAction("Index", "Home");
        }
    }
}
