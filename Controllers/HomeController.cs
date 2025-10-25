using System.Diagnostics;
using exWeb001.Models;
using Microsoft.AspNetCore.Mvc;

namespace exWeb001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Relatorio()
        {
            var alunos = _alunoRepositorio.BuscarAlunos();
            var turmas = _turmaRepositorio BuscarTurmas();

            List<RelatorioViewModel> relatorioViewModels = alunos
                .Select(x => new RelatorioViewModel
                {
                    Aluno = x,
                    Turma = turmas.FirstOrDefault(y => y.Id == x.IdTurma)
                }).ToList();
        }
    }
}
