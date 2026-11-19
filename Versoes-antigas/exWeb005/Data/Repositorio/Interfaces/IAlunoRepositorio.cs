using exWeb001.Models;
using System.Collections.Generic;

namespace exWeb001.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        void CadastrarAluno(Aluno aluno);
        List<Aluno> BuscarAlunos();
        Aluno BuscarPorId(int id);
        void AtualizarAluno(Aluno aluno);
        void ExcluirAluno(int id);
    }
}
