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

        public async Task<IActionResult> CardapioLanches()
        {
            var produtos = await _context.Produtos
                .Where(p => p.Categoria == Categorias.Lanches).ToListAsync();

            return View(produtos);
        }

        public async Task<IActionResult> CardapioBebidas()
        {
            var produtos = await _context.Produtos
                .Where(p => p.Categoria == Categorias.Bebidas).ToListAsync();

            return View(produtos);
        }
        public async Task<IActionResult> CardapioSobremesas()
        {
            var produtos = await _context.Produtos
                .Where(p => p.Categoria == Categorias.Sobremesas).ToListAsync();

            return View(produtos);
        }
        public async Task<IActionResult> CardapioOutros()
        {
            var produtos = await _context.Produtos
                .Where(p => p.Categoria == Categorias.Outros).ToListAsync();

            return View(produtos);
        }

        public async Task<IActionResult> Pedidos(int? id)
        {
            if (id == null)
            {
                return View();
            }

            var produto = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

            if (produto == null) return NotFound();

            return View(produto);
        }

        public async Task<IActionResult> ConfirmaPedidos(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var mesa = HttpContext.Session.GetString("mesa");
            ViewBag.Mesa = mesa;

            var produto = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

            if (produto == null) return NotFound();

            return View(produto);
        }
        public IActionResult ConfirmarPedido()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PedidoSend()
        {

            var mesa = int.Parse(HttpContext.Session.GetString("mesa"));
            ViewBag.Mesa = mesa;

            var pedido = await _context.Pedidos.FirstOrDefaultAsync(x => x.MesaId == mesa);

            if (pedido == null)
            {

                 Pedido newPedido(int mesa)
                {
                    return new Pedido
                    {
                        Data = DateTime.Now,
                        StatusId = 2,
                        MesaId = mesa
                    };
                }

                var novoPedido = newPedido(mesa);
                await _context.Pedidos.AddAsync(novoPedido);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(CardapioLanches));
        }

        /*private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id); =>  ainda não achamos o pilantra
        }
        */
    }
}
