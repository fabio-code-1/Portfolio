using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using System.Diagnostics;


namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto _contexto;
        public HomeController(ILogger<HomeController> logger, Contexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index(string? scrollTo = null)
        {
            ViewBag.ScrollTo = scrollTo; // passa o valor do parâmetro para a ViewBag

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Facts()
        {
            return View();
        }

        public IActionResult Skill()
        {
            return View();
        }


        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Testimonials()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contato model)
        {
            if (ModelState.IsValid)
            {
                // Salva a mensagem no banco de dados
                _contexto.Add(model);
                _contexto.SaveChanges();

                // Armazena a mensagem de sucesso na TempData
                TempData["MensagemSucesso"] = "Sua mensagem foi enviada. Obrigado!";

                // Redireciona de volta para a página
                return RedirectToAction("Index", new { scrollTo = "contact" });

            }
            else
            {
                // Armazena a mensagem de erro na TempData
                TempData["MensagemErro"] = "Por favor, preencha todos os campos corretamente.";

                // Retorna para a página
                return View(model);
            }
        }








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}