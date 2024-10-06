using Pizzaria2._0.Data.Repository.Interfaces;
using Pizzaria2._0.Models;
using Pizzaria2._0.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria2._0.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public AccountRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public void CreateAccount(RegisterViewModel viewModel)
        {
            // Create new Account entity
            var account = new Account
            {
                Nome = viewModel.Nome,
                Sobrenome = viewModel.Sobrenome,
                DataNascimento = viewModel.DataNascimento,
                Email = viewModel.Email,
                Senha = viewModel.Senha,
                AccountAddresses = new List<AccountAddress>()
            };

            // Create a new Address entity
            var address = new Address
            {
                Cep = viewModel.Cep,
                Estado = viewModel.Estado,
                Cidade = viewModel.Cidade,
                Bairro = viewModel.Bairro,
                Rua = viewModel.Rua,
                Numero = viewModel.Numero,
                Complemento = viewModel.Complemento
            };

            // Create new AccountAddress entity
            var accountAddress = new AccountAddress
            {
                Address = address  // Associar o endereço (novo)
            };

            // Associar a nova conta ao AccountAddress
            accountAddress.Account = account;

            // Adicionar o endereço à coleção de endereços da conta
            account.AccountAddresses.Add(accountAddress);

            // Add the account to the database context
            _dataBaseContext.Accounts.Add(account);

            // Save changes to the database to generate the Id for the account
            _dataBaseContext.SaveChanges();

            // Now we can create the UserIdentification since we have the Account ID
            var userIdentification = new UserIdentification
            {
                Cpf = viewModel.Cpf,         // Adicionar CPF da viewModel
                AccountID = account.Id       // Associa a AccountID
            };

            // Adiciona o UserIdentification ao contexto
            _dataBaseContext.UserIdentifications.Add(userIdentification);

            // Save changes to the database again
            _dataBaseContext.SaveChanges();
        }

        public Account LoginValidation(string email, string senha)
        {
            var account = _dataBaseContext.Accounts.FirstOrDefault(x => x.Email == email);

            if (account != null && account.Senha == senha) // Considere usar verificação de hash
            {
                return account;
            }

            return null;
        }

    }
}
