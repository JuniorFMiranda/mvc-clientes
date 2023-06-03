using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcClientes.Context;
using MvcClientes.Models;

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
            var clientes = _context.Cliente.ToList();
            return View(clientes);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Editar(int id)
        {
            var cliente = _context.Cliente.Find(id);
            
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(Cliente cliente)
        {
            var clienteDb = _context.Cliente.Find(cliente.Id);

            clienteDb.Nome = cliente.Nome;
            clienteDb.Documento = cliente.Documento;
            clienteDb.Ativo = cliente.Ativo;
            clienteDb.LimiteCredito = cliente.LimiteCredito;

            _context.Cliente.Update(clienteDb);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Visualizar(int id)
        {
            var cliente = _context.Cliente.Find(id);

            return View(cliente);
        }
    }
}