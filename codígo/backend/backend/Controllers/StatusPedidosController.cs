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
    public class StatusPedidosController : Controller
    {
        private readonly AppDbContext _context;

        public StatusPedidosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StatusPedidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.StatusPedidos.ToListAsync());
        }

        // GET: StatusPedidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StatusPedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] StatusPedido statusPedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusPedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statusPedido);
        }

        // GET: StatusPedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusPedido = await _context.StatusPedidos.FindAsync(id);
            if (statusPedido == null)
            {
                return NotFound();
            }
            return View(statusPedido);
        }

        // POST: StatusPedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] StatusPedido statusPedido)
        {
            if (id != statusPedido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusPedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusPedidoExists(statusPedido.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(statusPedido);
        }

        // GET: StatusPedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusPedido = await _context.StatusPedidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusPedido == null)
            {
                return NotFound();
            }

            return View(statusPedido);
        }

        // POST: StatusPedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statusPedido = await _context.StatusPedidos.FindAsync(id);
            if (statusPedido != null)
            {
                _context.StatusPedidos.Remove(statusPedido);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusPedidoExists(int id)
        {
            return _context.StatusPedidos.Any(e => e.Id == id);
        }
    }
}
