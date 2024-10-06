
using Pizzaria2._0.Models;
using Pizzaria2._0.ViewModels;

namespace Pizzaria2._0.Data.Repository.Interfaces
{
	public interface IAccountRepository
	{
        void CreateAccount(RegisterViewModel viewModel);

        public Account LoginValidation(string email, string senha);

    }
}
