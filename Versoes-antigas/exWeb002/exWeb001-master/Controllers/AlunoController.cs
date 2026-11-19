using exWeb001.Models;
using Microsoft.AspNetCore.Mvc;

namespace exWeb001.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult AdicionarAluno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarAluno(Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                TempData["MsgSucesso"] = "Aluno cadastrado com sucesso!";
                return RedirectToAction("Index"); 
            }

            TempData["MsgErro"] = "Erro ao cadastrar aluno!";
            return View(usuario);
        }
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
