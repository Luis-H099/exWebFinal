using exWeb001.Data.Repositorio.Interfaces;
using exWeb001.Models;

namespace exWeb001.Data.Repositorio
{
    public class TurmaRepositorio : ITurmaRepositorio
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        private readonly ITurmaRepositorio _turmaRepositorio;

        public TurmaRepositorio(IAlunoRepositorio alunoRepositorio, ITurmaRepositorio turmaRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
            _turmaRepositorio = turmaRepositorio;
        }

        public IEnumerable<Turma> BuscarTurmas()
        {
        }

        public List<RelatorioViewModel> GerarRelatorio()
        {
            var alunos = _alunoRepositorio.BuscarAlunos();
            var turmas = _turmaRepositorio.BuscarTurmas();

            var relatorioViewModels = alunos
                .Select(x => new RelatorioViewModel
                {
                    Aluno = x,
                    Turma = turmas.FirstOrDefault(y => y.Id == x.IdTurma)
                })
                .ToList();

            return relatorioViewModels;
        }
    }

}
