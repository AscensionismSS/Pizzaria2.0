using Microsoft.AspNetCore.Mvc;
using Pizzaria2._0.Data.Repository.Interfaces;

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


		public IActionResult Register(RegisterViewModel viewModel)
		{
			if (ModelState.IsValid)
			{
				_accountRepository.CreateAccount(viewModel);
				return RedirectToAction("Index", "Home");
			}
			return View(viewModel);
		}
	}


}



