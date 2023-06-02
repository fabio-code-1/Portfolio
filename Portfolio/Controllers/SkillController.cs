using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Linq;

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly Contexto _contexto;

        public SkillController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Skills()
        {
            var skills = _contexto.Skills.ToList();

            // Verificar os dados no console
            foreach (var skill in skills)
            {
                Console.WriteLine($"ID: {skill.Id}");
                Console.WriteLine($"Tecnologia: {skill.Tecnologia}");
                Console.WriteLine($"Porcentagem: {skill.Porcentagem}");
                Console.WriteLine($"Exibir Div: {skill.ExibirDiv}");
                Console.WriteLine("===============================");
            }

            return View(skills);

        }
    }
}
