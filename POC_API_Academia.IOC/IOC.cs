using Microsoft.Extensions.DependencyInjection;
using POC_API_Academia.Apllication.Funcionarios;
using POC_API_Academia.Domain.Funcionarios;
using POC_API_Academia.MySQL.Funcionarios;

namespace POC_API_Academia.IOC
{
    public static class IOC
    {
        public static void ConfigureService(IServiceCollection services)    
        {
            services.AddTransient<IFuncionarioDomain, FuncionarioDomain>();
            services.AddTransient<IFuncionarioApplication, FuncionarioApplication>();
            services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
        }
    }
}
