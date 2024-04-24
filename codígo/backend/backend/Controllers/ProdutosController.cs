using backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace backend.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;
        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Produtos.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View(new ProdutoViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProdutoViewModel model)
        {

            if (ModelState.IsValid)
            {
                var produto = new Produto();
                produto.nome = model.nome;
                produto.valor = model.valor;
                produto.categoria = model.categoria;
                produto.descricao = model.descricao;

                if (model.ImageUpload != null && model.ImageUpload.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.ImageUpload.CopyToAsync(memoryStream);
                        produto.imagem = memoryStream.ToArray();
                    }

                    _context.Produtos.Add(produto);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");

                }
                
            }
            return View(model);
        }
    }
}