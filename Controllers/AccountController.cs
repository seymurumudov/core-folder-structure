using ConsoleApp6.Helpers;
using ConsoleApp6.Models;

namespace ConsoleApp6.Controllers
{
    internal class AccountController
    {
        private List<Account> Accounts { get; set; }

        public AccountController()
        {
            Accounts = new List<Account>();
        }

        public void GetAccountByNo()
        {
            Console.WriteLine("hesab normesini daxil edin:");
            int accountNo = int.Parse(Console.ReadLine());
            Account account = new Account
            {
                Balance = 12,
                Currency = 56
            };
        }

        public void CreateAccount()
        {
            int accounNo = SiteHelpers.GenerateRandomNumbers(8);
        }
    }
}

// CRUD
