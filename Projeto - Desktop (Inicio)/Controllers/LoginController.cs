using Microsoft.AspNetCore.Mvc;
using RecursosHumanos.Models;
using RecursosHumanos.Repositorio;

namespace RecursosHumandos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        public LoginController(IFuncionarioRepositorio funcionarioRepositorio)
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    FuncionarioModel funcionario = _funcionarioRepositorio.BuscarPorLogin(loginModel.Email);

                    if (funcionario != null)
                    {
                        if (funcionario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Senha inválida. Por favor, tente novamente.";

                    }

                    TempData["MensagemErro"] = $"Email e/ou senha inválido(s). Por favor, tente novamente.";

                }

                return View("Index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }


        }

    }

}
