using System.Diagnostics;
using exWeb001.Data.Repositorio.Interfaces;
using exWeb001.Models;
using Microsoft.AspNetCore.Mvc;

namespace exWeb001.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITurmaRepositorio _turmaRepositorio;
        private readonly ITurmaRepositorio _alunoRepositorio;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ITurmaRepositorio alunoRepositorio, ITurmaRepositorio turmaRepositorio)
        {
            _logger = logger;
            _alunoRepositorio = alunoRepositorio;
            _turmaRepositorio = turmaRepositorio;
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
            var alunos = _alunoRepositorio.BuscarPorNome();

            var relatorioViewModels = alunos
                .Select(x => new RelatorioViewModel
                {
                    Aluno = x,
                    Turma = _turmaRepositorio.BuscarTurmasPorId(x.IdTurma)
                })
                .ToList();

            return View(relatorioViewModels);
        }
    }
}
