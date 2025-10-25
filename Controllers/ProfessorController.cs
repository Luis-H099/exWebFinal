using exWeb001.Data.Repositorio.Interfaces;
using exWeb001.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace exWeb001.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _professorRepositorio;

        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }

        public IActionResult Index(string nome)
        {
            List<Professor> professores;

            if (!string.IsNullOrEmpty(nome))
            {
                professores = _professorRepositorio.BuscarPorNome(nome);
            }
            else
            {
                professores = _professorRepositorio.BuscarProfessores();
            }

            return View(professores);
        }

        public IActionResult AdicionarProfessor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarProfessor(Professor professor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _professorRepositorio.CadastrarProfessor(professor);
                    return RedirectToAction("Index");
                }

                return View("AdicionarProfessor", professor);
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var professor = _professorRepositorio.BuscarPorId(id);
            if (professor == null)
                return NotFound();

            return View(professor);
        }

        [HttpPost]
        public IActionResult Editar(Professor professor)
        {
            _professorRepositorio.AtualizarProfessor(professor);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            var professor = _professorRepositorio.BuscarPorId(id);
            if (professor == null)
            {
                return NotFound();
            }
            return View(professor);
        }

        [HttpPost]
        public IActionResult ExcluirConfirmado(int id)
        {
            _professorRepositorio.ExcluirProfessor(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BuscarPorId(int id)
        {
            var professor = _professorRepositorio.BuscarPorId(id);
            if (professor == null)
            {
                TempData["MensagemErro"] = "Professor não encontrado.";
                return RedirectToAction("Index");
            }

            return View("Detalhes", professor);
        }
    }
}
