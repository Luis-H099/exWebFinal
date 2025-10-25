using exWeb001.Data;
using exWeb001.Data.Repositorio.Interfaces;
using exWeb001.Models;
using System.Collections.Generic;
using System.Linq;

public class ProfessorRepositorio : IProfessorRepositorio
{
    private readonly BancoContexto _context;

    public ProfessorRepositorio(BancoContexto context)
    {
        _context = context;
    }

    public void CadastrarProfessor(Professor professor)
    {
        _context.Professor.Add(professor);
        _context.SaveChanges();
    }

    public List<Professor> BuscarProfessores()
    {
        return _context.Professor.ToList();
    }

    public Professor BuscarPorId(int id)
    {
        return _context.Professor.FirstOrDefault(p => p.Id == id);
    }

    public List<Professor> BuscarPorNome(string nome)
    {
        return _context.Professor
            .Where(p => p.Nome.ToLower().Contains(nome.ToLower()))
            .ToList();
    }

    public void AtualizarProfessor(Professor professor)
    {
        _context.Professor.Update(professor);
        _context.SaveChanges();
    }

    public void ExcluirProfessor(int id)
    {
        var professor = BuscarPorId(id);
        if (professor != null)
        {
            _context.Professor.Remove(professor);
            _context.SaveChanges();
        }
    }
}
