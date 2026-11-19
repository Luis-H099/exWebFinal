using exWeb001.Data.Repositorio.Interfaces;
using exWeb001.Models;
using Microsoft.AspNetCore.Mvc;

namespace exWeb001.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ValidaUsuario(Usuario usuario)
        {
            try
            {
                var retorno = _usuarioRepositorio.ValidarUsuario(usuario);

                if (retorno != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["MsgErro"] = "Usuário ou senha incorretos! Tente novamente...";
                }
            }
            catch (Exception)
            {

                TempData["MsgErro"] = "Erro ao buscar dados do usuário"; 
            }

            return View("index");
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult CadastrarUsuario(Usuario usuario)
        {

            try
            {
                _usuarioRepositorio.CadastrarUsuario(usuario);
                return RedirectToAction("Index", "Login");
            }
            catch (Exception e)
            {
                TempData["MsgErro"] = "Erro ao cadastrar usuário";
            }

            return View("Index");
        }
    }

}
