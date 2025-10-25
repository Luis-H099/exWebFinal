using exWeb001.Models;

namespace exWeb001.Data.Repositorio.Interfaces
{
    public interface ITurmaRepositorio
    {
        IEnumerable<Turma> BuscarTurmas();
        List<RelatorioViewModel> GerarRelatorio();
        public IEnumerable<Turma> BuscarTurmasPorId();
        public Turma? BuscarTurmasPorId(int id);
    }

}
