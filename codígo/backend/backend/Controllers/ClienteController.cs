using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cliente
        public async Task<IActionResult> Inicio()
        {
            return View(await _context.Produtos.ToListAsync());
        }
        public async Task<IActionResult> CardapioPprincipal()
        {
            return View(await _context.Produtos.ToListAsync());
        }
        public async Task<IActionResult> CardapioBebidas()
        {
            return View(await _context.Produtos.ToListAsync());
        }

        public IActionResult Pedidos()
        {
            return View();
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
