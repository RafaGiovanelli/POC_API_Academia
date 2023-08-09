using Microsoft.AspNetCore.Mvc;
using POC_API_Academia.Apllication.Funcionarios;
using POC_API_Academia.Models.Funcionario;

namespace POC_API_Academia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FuncionarioController : ControllerBase
    {
        private IFuncionarioApplication _funcionarioApplication;

        public FuncionarioController(IFuncionarioApplication funcionarioApplication)
        {
            _funcionarioApplication = funcionarioApplication;
        }

        [HttpGet ("Lista Funcionarios")]
        public List<Funcionario> ListaFuncionario()
        {
            return _funcionarioApplication.ListFuncionarios();
        }
    }
}
