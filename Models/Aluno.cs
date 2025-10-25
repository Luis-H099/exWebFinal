namespace exWeb001.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public int IdTurma { get; set; }
        public string Nome { get; set; }
        public DateOnly Data_De_Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
    }
}
