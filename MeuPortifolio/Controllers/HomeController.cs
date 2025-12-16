using Microsoft.AspNetCore.Hosting.Server;
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
            ViewData["Telefone"] = "(79) 9 9888-5097";
            ViewData["Email"] = "micaely.oliveira@dcomp.ufs.br";
            ViewData["GitHub"] = "https://github.com/MicaelyCacho";
            ViewData["Linkedin"] = "www.linkedin.com/in/micaelycacho";

            var habilidades = new List<string>
            {
                "JAVASCRIPT",
                "C#",
                "SQL Server",
                "PYTHON",
                "HTML",
                "CSS",
                "SCRUM",
                "INGLÊS INTERMEDIÁRIO/AVANÇADO"
            };
            ViewData["Habilidades"] = habilidades;

            var projetos = new List<Projeto>
            {
                new Projeto
                {
                    Titulo = "SISTEMA DE CUIDADOS COM PLANTAS (CRUD)",
                    Descricao = "Desenvolvimento de sistema de cadastro de plantas com C# e arquitetura MVC, e banco de\r\ndados SQL Server. Projeto focado em organização do código e boas práticas.\r\n",
                    Tecnologias = "C# + SQL SERVER E MVC",
                    Link = "#"
                },
                new Projeto
                {
                    Titulo = "API EMPRESARIAL",
                    Descricao = "Desenvolvimento de backend com .NET Core, Entity Framework e documentação Swagger",
                    Tecnologias = "C# + SQL SERVER",
                    Link = "#"
                },
                new Projeto
                {
                    Titulo = "DESENVOLVIMENTO DE APLICATIVO MOBILE PARA ADOÇÃO DE ANIMAIS",
                    Descricao = "Criação de app Android utilizando Kodular, plataforma no-code, facilitando a adoção de\r\npets.\r\n",
                    Tecnologias = "KODULAR + Figma",
                    Link = "#"
                },
                new Projeto
                {
                    Titulo = "DESENVOLVIMENTO DE SITE DE ESTUDOS",
                    Descricao = "Projeto em grupo (3 pessoas) com múltiplas abas para organização do conteúdo.\r\nIntegração com API do YouTube para exibição de vídeos educacionais.",
                    Tecnologias = "JAVASCRIPT, HTML, CSS, BOOTSTRAP ",
                    Link = "https://github.com/MicaelyCacho/k4fem-renaissance-platform"
                },
                new Projeto
                {
                    Titulo = "CONSUMO DE API",
                    Descricao = "Consumo de API OpenWeather e estilização",
                    Tecnologias = "JAVASCRIPT, HTML, CSS",
                    Link = "https://github.com/MicaelyCacho/PrevisaoDoTempo~"
                },
                new Projeto
                {
                    Titulo = "CONSUMO DE API",
                    Descricao = "Consumo de API Busca CEP e estilização",
                    Tecnologias = "JAVASCRIPT, HTML, CSS",
                    Link = "https://github.com/MicaelyCacho/BuscaCEP"
                },
                new Projeto
                {
                    Titulo = "E-Comerce",
                    Descricao = "E-Comerce de lanchonete com estilização",
                    Tecnologias = "JAVASCRIPT, HTML, CSS",
                    Link = "https://github.com/MicaelyCacho/E-comerce"
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