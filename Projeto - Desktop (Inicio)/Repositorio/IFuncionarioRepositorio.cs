using RecursosHumanos.Models;

namespace RecursosHumanos.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        FuncionarioModel BuscarPorLogin(string email);
    }
}
