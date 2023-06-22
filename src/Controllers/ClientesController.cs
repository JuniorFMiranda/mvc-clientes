using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcClientes.Context;
using MvcClientes.Models;
using MvcClientes.Services;

namespace MvcClientes.Controllers
{
    [Route("")]
    [Route("gestao-cliente")]
    public class ClientesController : Controller
    {
        private readonly ClienteDbContext _context;
    
        public ClientesController(ClienteDbContext context)
        {
            _context = context;
        }
        
        [Route("")]
        [Route("lista")]
        public IActionResult Index()
        {
            var clientes = _context.Clientes.ToList();
            return View(clientes);
        }

        [Route("novo")]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [Route("novo")]
        public IActionResult Criar(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
               _context.Clientes.Add(cliente);
               _context.SaveChanges();

               return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        [Route("editar/{id:int}")]
        public IActionResult Editar(int id)
        {
            var cliente = _context.Clientes.Find(id);
            
            return View(cliente);
        }

        [HttpPost]
        [Route("editar/{id:int}")]
        public IActionResult Editar(Cliente cliente)
        {
            var clienteDb = _context.Clientes.Find(cliente.Id);
            
            if (ModelState.IsValid)
            {
                clienteDb.Nome = cliente.Nome;
                clienteDb.Documento = cliente.Documento;
                clienteDb.Ativo = cliente.Ativo;
                clienteDb.LimiteCredito = cliente.LimiteCredito;

                _context.Clientes.Update(clienteDb);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(clienteDb);
        }

        [Route("visualizar/{id:int}")]
        public IActionResult Visualizar(int id)
        {
            var cliente = _context.Clientes.Find(id);

            return View(cliente);
        }

         [Route("Excluir/{id:int}")]
        public IActionResult Excluir(int id)
        {
            var cliente = _context.Clientes.Find(id);

            return View(cliente);
        }

        [HttpPost]
        [Route("Excluir/{id:int}")]
        public IActionResult Excluir(Cliente cliente)
        {
            var clienteDb = _context.Clientes.Find(cliente.Id);

            if (clienteDb == null)
                return RedirectToAction(nameof(Index));

            _context.Clientes.Remove(clienteDb);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}