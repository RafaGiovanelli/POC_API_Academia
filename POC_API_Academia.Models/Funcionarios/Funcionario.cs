namespace POC_API_Academia.Models.Funcionario
{
    public class Funcionario
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }

    }
}
