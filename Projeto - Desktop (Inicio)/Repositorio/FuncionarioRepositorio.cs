using RecursosHumanos.Context;
using RecursosHumanos.Models;

namespace RecursosHumanos.Repositorio
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public FuncionarioModel BuscarPorLogin(string email)
        {
            return _bancoContext.FuncionarioModel.First(x => x.Email.ToUpper() == email.ToUpper());
        }
        public FuncionarioRepositorio(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }
       
    }
}