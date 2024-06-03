using backend.Models;
using backend.Services.Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Drawing.Text;

namespace backend.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly FileUpload _fileUpload;
        private string _filePath;

        public ProdutosController(AppDbContext context, IWebHostEnvironment env, FileUpload fileUpload)
        {
            _context = context;
            _filePath = env.WebRootPath;
            _fileUpload = fileUpload;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Produtos.ToListAsync();

            return View(dados);
        }
        public IActionResult Cliente()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null) return NotFound();

            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto produto,IFormFile anexo)
        {
            if (ModelState.IsValid)
            {
                if (!ImageIsValid(anexo))
                    return View(produto);


                var nome =  await SaveFileAsync(anexo);
                produto.Imagem = nome.ToString();


            
                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(produto);

        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var produto = await _context.Produtos.FindAsync(id);
            var Img = await _context.Produtos.Select(p => p.Imagem).ToListAsync();

            if (produto == null) return NotFound();

            var viewModel = new ProdutoViewModel
            {
                Produto = produto,
                Imagens = Img
            };

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Valor,Categoria,Imagem")] Produto produto, IFormFile anexo)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }
            if (anexo == null)
            {
                return View(produto);
            }

            if (ModelState.IsValid)
            {
                if (!ImageIsValid(anexo))
                    return View(produto);


                var nome = SaveFileAsync(anexo);
                produto.Imagem = nome.ToString();

                _context.Update(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        public async Task<IActionResult> Imagens()
        {
            var produtos = await _context.Produtos.ToListAsync();

            if (produtos == null || !produtos.Any())
            {
                return NotFound();
            }

            var todasImagens = new List<string>();

            foreach (var produto in produtos)
            {
                if (produto.Imagens != null && produto.Imagens.Any())
                {
                    todasImagens.AddRange(produto.Imagens);
                }
            }

            return View(todasImagens);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<string> SaveFileAsync(IFormFile anexo)
        {
            var nameUri = await _fileUpload.UploadAsync(anexo);
            return nameUri.ToString();
        }
        

        public bool ImageIsValid(IFormFile anexo)
        {
            if (anexo == null)
            {
                return false;
            }
            switch (anexo.ContentType)
            {
                case "image/jpeg":
                    return true;
                case "image/jpg":
                    return true;
                case "image/png":
                    return true;
                default:
                    return false;
            }
        }
    }
}