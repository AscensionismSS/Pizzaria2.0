using Microsoft.AspNetCore.Mvc;
using Pizzaria2._0.Data.Repository.Interfaces;
using Pizzaria2._0.Models;
using Pizzaria2._0.ViewModels;

namespace Pizzaria2._0.Controllers
{
	public class AuthController : Controller
	{
		private readonly IAccountRepository _accountRepository;

		public AuthController(IAccountRepository accountRepository)
		{
			_accountRepository = accountRepository;
		}


		public IActionResult Index()
		{
			return View();
		}

        public IActionResult Login()
        {
            return View(); 
        }


        public IActionResult Register(RegisterViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				_accountRepository.CreateAccount(viewModel);
				return RedirectToAction("Index", "Home");
			}
			return View(viewModel);
		}


        public IActionResult SignIn(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", loginViewModel); // Retorna a view com erros
            }

            var usuarioDb = _accountRepository.LoginValidation(loginViewModel.Email, loginViewModel.Senha);

            if (usuarioDb != null)
            {
                return RedirectToAction("Index", "AdminDashboard");
            }

            ModelState.AddModelError("", "Email ou senha inválidos.");
            return View("Login", loginViewModel); // Retorna o modelo preenchido
        }
    }
}



