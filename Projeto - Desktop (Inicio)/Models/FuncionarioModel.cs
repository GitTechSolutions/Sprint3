using RecursosHumanos.Context;
namespace RecursosHumanos.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }

        public bool SenhaValida(string senha)
        {
            return Cpf == senha;
        }
    }
}