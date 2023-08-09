using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using POC_API_Academia.Models.Funcionario;

namespace POC_API_Academia.MySQL.Funcionarios
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private IConfiguration _configuration;
        private MySqlConnection _mySqlConn;

        public FuncionarioRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _mySqlConn = GetConnection();
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(_configuration.GetSection("ConnectionStrings:MySQL").Value);
        }

        public List<Funcionario> ListFuncionarios()
        {
            try
            {
                _mySqlConn.Open();

                return _mySqlConn.Query<Funcionario>("select * from Funcionario").ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _mySqlConn.Close();
            }
        }
    }
}
