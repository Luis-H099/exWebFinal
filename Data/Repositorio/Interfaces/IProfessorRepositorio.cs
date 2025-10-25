using exWeb001.Models;
using System.Collections.Generic;

namespace exWeb001.Data.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {
        void CadastrarProfessor(Professor professor);
        List<Professor> BuscarProfessores();
        Professor BuscarPorId(int id);
        void AtualizarProfessor(Professor professor);
        void ExcluirProfessor(int id);
        List<Professor> BuscarPorNome(string nome);
    }
}
