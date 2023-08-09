using POC_API_Academia.Models.Funcionario;

namespace POC_API_Academia.MySQL.Funcionarios
{
    public interface IFuncionarioRepository
    {
        List<Funcionario> ListFuncionarios();
    }
}
