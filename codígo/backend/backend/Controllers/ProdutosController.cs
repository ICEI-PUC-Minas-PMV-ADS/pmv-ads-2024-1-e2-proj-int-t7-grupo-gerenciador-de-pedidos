using backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;
        private string _filePath;

        public ProdutosController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _filePath = env.WebRootPath;
        }

        //GET
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Produtos.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto produto,IFormFile anexo)
        {
            if (ModelState.IsValid)
            {
                if (!ImageIsValid(anexo))
                    return View(produto);


            var nome = SaveFile(anexo);
            produto.Imagem = nome;


            
                _context.Produtos.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(produto);

        }
        public string SaveFile(IFormFile anexo)
        {
            var nome = Guid.NewGuid().ToString() + anexo.FileName;

            var filePath = _filePath + "//assets";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            using (var stream = System.IO.File.Create(filePath + "\\" + nome))
            {
                anexo.CopyToAsync(stream);
            }

            return nome;
        }

        public bool ImageIsValid(IFormFile anexo)
        {
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