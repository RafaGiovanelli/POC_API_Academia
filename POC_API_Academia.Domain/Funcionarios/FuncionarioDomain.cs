using POC_API_Academia.Models.Funcionario;
using POC_API_Academia.MySQL.Funcionarios;

namespace POC_API_Academia.Domain.Funcionarios
{
    public class FuncionarioDomain : IFuncionarioDomain
    {
        private IFuncionarioRepository _funcionarioRepository;

        public FuncionarioDomain(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public List<Funcionario> ListFuncionarios()
        {
            return _funcionarioRepository.ListFuncionarios();
        }

        public Funcionario GetFuncionario(int id) 
        {
            return _funcionarioRepository.GetFuncionario(id);
        }
    }
}
