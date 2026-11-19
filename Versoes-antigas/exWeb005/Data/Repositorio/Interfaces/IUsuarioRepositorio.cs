using exWeb001.Models;

namespace exWeb001.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        public void CadastrarUsuario(Usuario usuario);

        public Usuario ValidarUsuario(Usuario usuario);
    }
}
