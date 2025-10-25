using exWeb001.Data.Repositorio.Interfaces;
using exWeb001.Models;

namespace exWeb001.Data.Repositorio
{
    public class TurmaRepositorio : ITurmaRepositorio
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        private readonly ITurmaRepositorio _turmaRepositorio;
        private readonly BancoContexto _bancoContexto;

        public TurmaRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }
        public TurmaRepositorio(IAlunoRepositorio alunoRepositorio, ITurmaRepositorio turmaRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
            _turmaRepositorio = turmaRepositorio;
        }
        public Turma? BuscarTurmasPorId(int id)
        {
            return _bancoContexto.Turma.FirstOrDefault(t => t.IdTurma == id);
        }
        public IEnumerable<Turma> BuscarTurmasPorId()
        {
            return _bancoContexto.Turma.ToList();
        }
    }

}
