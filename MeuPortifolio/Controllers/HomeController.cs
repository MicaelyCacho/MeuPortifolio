using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeuPortifolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Nome"] = "Micaely";
            ViewData["Titulo"] = "Desenvolvedor JavaScript | C# | My SQL";

            var habilidades = new List<string>
            {
                "C# e .NET Framework/Core",
                "Entity Framework Core",
                "SQL Server e MySQL",
                "HTML5, CSS3, JavaScript",
                "APIs REST com ASP.NET",
            };
            ViewData["Habilidades"] = habilidades;

            var projetos = new List<Projeto>
            {
                new Projeto
                {
                    Titulo = "Sistema de Gestão",
                    Descricao = "Sistema web completo para gestão empresarial",
                    Tecnologias = "C#, ASP.NET, SQL Server",
                    Link = "#"
                },
                new Projeto
                {
                    Titulo = "API REST",
                    Descricao = "API para integração de sistemas",
                    Tecnologias = "ASP.NET Core, Entity Framework, JWT",
                    Link = "#"
                }
            };
            ViewData["Projetos"] = projetos;

            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
    public class Projeto
    {
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Tecnologias { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }
}