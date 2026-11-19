using exWeb001.Data;
using exWeb001.Data.Repositorio.Interfaces;
using exWeb001.Models;

public class AlunoRepositorio : IAlunoRepositorio
{
    private readonly BancoContexto _context;

    public AlunoRepositorio(BancoContexto context)
    {
        _context = context;
    }

    public void CadastrarAluno(Aluno aluno)
    {
        _context.Aluno.Add(aluno);
        _context.SaveChanges();
    }

    public List<Aluno> BuscarAlunos()
    {
        return _context.Aluno.ToList();
    }

    public Aluno BuscarPorId(int id)
    {
        return _context.Aluno.FirstOrDefault(a => a.Id == id);
    }

    public void AtualizarAluno(Aluno aluno)
    {
        _context.Aluno.Update(aluno);
        _context.SaveChanges();
    }

    public void ExcluirAluno(int id)
    {
        var aluno = BuscarPorId(id);
        if (aluno != null)
        {
            _context.Aluno.Remove(aluno);
            _context.SaveChanges();
        }
    }
}
