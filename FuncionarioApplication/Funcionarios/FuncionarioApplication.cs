using POC_API_Academia.Domain.Funcionarios;
using POC_API_Academia.Models.Funcionario;

namespace POC_API_Academia.Apllication.Funcionarios
{
    public class FuncionarioApplication : IFuncionarioApplication
    {
        private IFuncionarioDomain _funcionarioDomain;

        public FuncionarioApplication(IFuncionarioDomain funcionarioDomain)
        {
            _funcionarioDomain = funcionarioDomain;
        }

        public List<Funcionario> ListFuncionarios()
        {
            return _funcionarioDomain.ListFuncionarios();
        }
    }
}
