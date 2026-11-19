using exWeb001.Data.Repositorio.Interfaces;
using exWeb001.Models;
using Microsoft.AspNetCore.Mvc;

namespace exWeb001.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public IActionResult Index()
        {
            var alunos = _alunoRepositorio.BuscarAlunos();
            return View(alunos);
        }

        public IActionResult AdicionarAluno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarAluno(Aluno aluno)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _alunoRepositorio.CadastrarAluno(aluno);
                    return RedirectToAction("Index");
                }

                return View("AdicionarAluno", aluno);
            }
            catch
            {

                throw;
            }
        }

        [HttpGet]
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var aluno = _alunoRepositorio.BuscarPorId(id);
            if (aluno == null)
                return NotFound();

            return View(aluno);
        }

        [HttpPost]
        public IActionResult Editar(Aluno aluno)
        {
            //if (!ModelState.IsValid)
            //    return View(aluno);

            _alunoRepositorio.AtualizarAluno(aluno);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            var aluno = _alunoRepositorio.BuscarPorId(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        [HttpPost]
        public IActionResult ExcluirConfirmado(int id)
        {
            _alunoRepositorio.ExcluirAluno(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BuscarPorId(int id)
        {
            var aluno = _alunoRepositorio.BuscarPorId(id);
            if (aluno == null)
            {
                TempData["MensagemErro"] = "Aluno não encontrado.";
                return RedirectToAction("Index");
            }

            return View("Detalhes", aluno);
        }
    }
}


