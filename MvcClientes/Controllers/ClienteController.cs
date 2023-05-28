using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcClientes.Context;

namespace MvcClientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteDbContext _context;

        public ClienteController(ClienteDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}