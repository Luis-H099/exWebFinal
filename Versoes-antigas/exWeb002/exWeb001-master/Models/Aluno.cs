namespace exWeb001.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Cpf { get; set; }
        public string Endereco { get; set; }
        public int Cep { get; set; }
        public DateOnly DataNascimento { get; set; }
        public int Matricula { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
    }
}
